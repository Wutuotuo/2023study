using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UImanager : MonoBehaviour
{
    [Header("单次得分")]
    public Text scoreText;
    [Header("游戏结束UI")]
    public GameObject gameOverPanel;
    [Header("排行榜UI")]
    public GameObject leaderboardpanel;
    //注册
    private void OnEnable()
    {
        //恢复暂停的时间
        Time.timeScale = 1;
        //使用+=来注册
        EventHandler.GetPointEvent += OnGetPointEvent;//注册函数的参数必须和方法相同
        EventHandler.GameOverEvent += OnGameOverEvent;
    }
    //注销
    private void OnDisable()
    {
        //使用-=来注销
        EventHandler.GetPointEvent -= OnGetPointEvent;//注销函数的参数必须和方法相同
        EventHandler.GameOverEvent -= OnGameOverEvent;
    }
   
    private void Start() 
    {
        scoreText.text = "00";
    }

    private void OnGetPointEvent(int point)
    {
        //转换字符串
        scoreText.text = point.ToString();
    }
    private void OnGameOverEvent()
    {
        //启用一个物体
        gameOverPanel.SetActive(true);
        if(gameOverPanel.activeInHierarchy)
        {
            //一直触发时会判断该窗口是否为激活状态，如果是则游戏时间暂停
            Time.timeScale = 0;
        }
    }
    #region 按钮添加方法
    public void RestartGame()
    {
        // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gameOverPanel.SetActive(false);
        Adsmanager.instance.ShowRewardAds();
        //FIXME在广告结束后转换场景
        TransitionManager.instance.Transition("Gameplay");
        //Invoke("WaitToTransition",1);
    }
    public void BackToMeau()
    {
        gameOverPanel.SetActive(false);
        TransitionManager.instance.Transition("Tiltle");
    }
    public void OpenLeaderBoard()
    {
        leaderboardpanel.SetActive(true);
    }
    private void WaitToTransition()
    {
        Debug.Log("ok");
        TransitionManager.instance.Transition("Gameplay");
    }
    #endregion
}
