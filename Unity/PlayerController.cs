using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
    //获得自身的组件，一般写在开头,获得的组件一般在Awake里初始化
    //获取Rigidbody2D组件
    private Rigidbody2D rb;
    //获取animator组件
    private Animator anim;
    private BoxCollider2D Bx2d;
    //获取SpriteRenderer组件
    private SpriteRenderer sr;
    private PlayerInput playerInput;
    //枚举变量 用于控制方向
    private enum Direction
    {
        up,right,left
    }
    public Terrn terrn;
    private Vector2 touchposition;
    private Direction dire;
    [Header("得分")]
    public float steppoint;
    [Header("跳跃")]
    public float jumpDistance;//跳跃的距离
     [Header("方向指示")]
     public SpriteRenderer spriteRenderer;
     public Sprite upSign;
     public Sprite leftSign;
     public Sprite rightSign;
    private float resultpoint;//总分
    private float moveDistance;//实际移动的距离
    private Vector2 destination;
    
    private bool buttonheld;//按键是否被长按
    private bool isjump;//跳跃途中的状态
    private bool canjump;//可以跳跃
    private bool isdead;//死亡不再生成地图
    private bool needhelp;
    private RaycastHit2D[] result = new RaycastHit2D[2];//不分配内存的物理射线检测
    public HelpManager helpManager;
    private void Update() 
    {
        //临时操作 跳跃到目标位置后重置跳跃状态
        //更改为了动画结束重置跳跃状态
        // if(destination.y - transform.position.y <= 0.1 )
        // isjump = false;
        if(canjump)
        {
            TrigerJump();
        }
        if(isdead)
        {
            DisableInput();
        }
    }
    private void OnEnable()
    {
        needhelp = GameManager.instance.GetNeedHelpData();
    }
    private void Start() {
        if(needhelp)
        helpManager.gameObject.SetActive(true);
        else
        helpManager.gameObject.SetActive(false);
    }
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        playerInput =  GetComponent<PlayerInput>();
        Bx2d = GetComponent<BoxCollider2D>(); 
    }
    //FixedUpdate是一个稳定的函数每0.2秒执行一次
    private void FixedUpdate()
    {
        //position 是一个二维向量,希望使用lerp线性差值移动到一个地方
        //必须在跳跃结束后才能跳跃
        if(isjump)
        {
            rb.position = Vector2.Lerp(transform.position,destination,0.134f);
        }
    }

    #region input 输入回调函数
    public void Jump(InputAction.CallbackContext context)
    {
        
        if(context.phase == InputActionPhase.Performed&&isjump == false)
        {
            moveDistance = jumpDistance;
            //Debug.Log("jump!");
            // destination = new Vector2(transform.position.x,transform.position.y+moveDistance);
            canjump = true;
            AudioManager.instance.SetJumpClip(0);
            if(dire ==  Direction.up)
            {
                resultpoint += steppoint; 
            }
        }
        
    }
    public void Longjump(InputAction.CallbackContext context)
    {
        if(context.performed&&isjump == false)
        {
            moveDistance = 2*jumpDistance;
            buttonheld = true;
            AudioManager.instance.SetJumpClip(1);
            spriteRenderer.gameObject.SetActive(true);
        }
        if(context.canceled && buttonheld == true && isjump == false)
        {
            
            

            if(dire ==  Direction.up)
            {
                resultpoint += steppoint*2; 
            }
            //Debug.Log("Longjump!");
            buttonheld = false;
            // destination = new Vector2(transform.position.x,transform.position.y+moveDistance);
            canjump = true;
            spriteRenderer.gameObject.SetActive(false);
        }
    }
    public void Gettouchposition(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            if(context.performed)
            {
                //世界坐标和屏幕坐标不相同
                //Debug.Log(context.ReadValue<Vector2>());
                touchposition = Camera.main.ScreenToWorldPoint(context.ReadValue<Vector2>());
                // Debug.Log(touchposition);
                var offset = ((Vector3)touchposition - transform.position).normalized;
                if(Mathf.Abs(offset.x)<=0.7f)
                {
                    dire = Direction.up;
                    spriteRenderer.sprite = upSign;
                }else if (offset.x < 0 )
                {
                    dire = Direction.left;
                    if(transform.localScale.x == -1)
                    spriteRenderer.sprite = rightSign;
                    else
                    spriteRenderer.sprite = leftSign;

                }else if (offset.x > 0)
                {
                    dire = Direction.right;
                    if(transform.localScale.x == -1)
                    spriteRenderer.sprite = leftSign;
                    else
                    spriteRenderer.sprite = rightSign;

                }
            
            }
        }
    }
    #endregion
    private void TrigerJump()
    {
        canjump = false;
        switch (dire)
        {
            case Direction.up:
            anim.SetBool("isside",false);
            destination = new Vector2(transform.position.x,transform.position.y+moveDistance);
            transform.localScale = Vector3.one;
            break;
            case Direction.left:
            anim.SetBool("isside",true);
            destination = new Vector2(transform.position.x - moveDistance,transform.position.y);
            transform.localScale = Vector3.one;          
            break;
            case Direction.right:
            anim.SetBool("isside",true);
            destination = new Vector2(transform.position.x + moveDistance,transform.position.y);
            transform.localScale = new Vector3(-1,1,1);
            break;
        }
        anim.SetTrigger("jump");
    }
    #region 通过动画控制跳跃
    public void JumpAnimationEvent()
    {
        //播放跳跃音效
        AudioManager.instance.PlayJumpFX();
        //改变状态
        isjump = true;
        //脱离父物体
        transform.parent = null; 
        // Debug.Log(dir);
        //修改图层顺序
        sr.sortingLayerName = "front";
        
        
    }
    public void FinishJumpAnimationEvent()
    {
        
        isjump = false;
        //修改图层顺序
        sr.sortingLayerName = "middle";
        if(!isdead && dire == Direction.up)
        {
            //得分触发地图检测
            //terrn.Checkposition();//耦合
            EventHandler.CallGetPointEvent((int)resultpoint);
            //Debug.Log("总得分"+resultpoint);
        }
    }
    #endregion
    //Collider2D other是除了青蛙之外，对方的触发器
    public void  OnTriggerStay2D(Collider2D other) 
    {
        if(other.CompareTag("Obs")&&!isjump)
        {
            //Debug.Log("Gameover!");
            isdead = true;
        }
        if(other.CompareTag("Border") || other.CompareTag("Car"))
        {
            //Debug.Log("gameover!");
            isdead = true;

        }
        if(other.CompareTag("Water")&&!isjump)
        {
            //通过青蛙发射向下的射线判断是水还是木板
            Physics2D.RaycastNonAlloc(transform.position + Vector3.up * 0.1f,Vector2.zero,result);
            //检测碰撞 在result的两个值中循环
            bool inwater = true;
            //result可以返回碰撞体
            foreach (var hit in result)
            { 
                if(hit.collider == null) continue;
                if(hit.collider.CompareTag("Wood"))
                {
                    transform.parent = hit.collider.transform;
                    inwater = false;
                }
            }
             if(inwater &&  !isjump)
                {
                    //Debug.Log("inwaterGG");
                    isdead = true;
                }
        }
        if(other.CompareTag("Help1"))//第一个碰到提示的检测
        {
        helpManager.SetHelpText("长按屏幕可以跳的更远");
        helpManager.CloseHandClick();
        helpManager.OpenHandTouch();
        }
        if(other.CompareTag("Help2"))//第2个碰到提示的检测
        {
        helpManager.SetHelpText("也可以触摸青蛙两侧进行跳跃");
        helpManager.CloseHandTouch();
        }
        if(other.CompareTag("Help3"))//第3个碰到提示的检测
        {
        helpManager.gameObject.SetActive(false);
        }

        if(isdead)
        {
            Bx2d.enabled = false;
            //广播通知游戏结束
            EventHandler.CallGameOverEvent();
            
        }     
       
    }
    // private void OnTriggerExit2D(Collider2D other) 
    // {
    //       transform.parent = null;  
    // } 
    private void DisableInput()//死亡时禁用游戏控制
    {
        playerInput.enabled = false ;
    }
}