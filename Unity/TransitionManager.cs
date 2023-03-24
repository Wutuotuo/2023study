using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TransitionManager : MonoBehaviour
{
    //创建一个静态实例，使其他脚本可以调用
    public static TransitionManager instance;//一般都写为instance;
    private CanvasGroup canvasGroup;
    [Header("时间")]
    public float scale;
    private void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        if (instance == null)
        {
            instance = this;
        }
        else 
            Destroy(this.gameObject);
        DontDestroyOnLoad(this);
    }
    private void Start() 
    {
        StartCoroutine(Fade(0));    
    }
    public void Transition(string sceneName)
    {
        Time.timeScale = 1;
        StartCoroutine(TransitionToScene(sceneName));
    }
    public void TransitionNot()
    {
        Time.timeScale = 1;
        StartCoroutine(TransitionNotToScene());
    }
    //协程函数迭代器 可以按照想要的顺序执行
    private IEnumerator TransitionToScene(string sceneName)
    {
        yield return Fade(1);
        yield return SceneManager.LoadSceneAsync(sceneName);
        yield return Fade(0);
    }
    private IEnumerator TransitionNotToScene()
    {
        yield return Fade(1);
        yield return Fade(0);
    }
    
    private IEnumerator Fade(int amount)//1是黑0是透明
    {
        canvasGroup.blocksRaycasts = true;
        while(canvasGroup.alpha != amount)
        {
            switch(amount)
            {
                case  1:
                    canvasGroup.alpha += Time.deltaTime * scale;
                    break;
                case  0:
                    canvasGroup.alpha -= Time.deltaTime * scale;
                    break;
            }
            // yield return null在循环里面相当于next，不满足条件就继续
            yield return null;
        }
        canvasGroup.blocksRaycasts = false; 
    }
    
}
