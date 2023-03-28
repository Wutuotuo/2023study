using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
//初始化监听 初始化加载 初始化显示
public class Adsmanager : MonoBehaviour,IUnityAdsInitializationListener,IUnityAdsLoadListener,IUnityAdsShowListener
{
    public static Adsmanager instance;
    #if UNITY_IOS
        private string gameID = "5215242";
        private string rewardPlacementID = "Rewarded_iOS";
        private string interPlacementID = "Interstitial_iOS";
    #elif UNITY_ANDROID
        private string gameID = "5215243";
        private string rewardPlacementID = "Rewarded_Android";
        private string interPlacementID = "Interstitial_Android";
    #endif
    private void Awake() 
    {
        if(instance ==null)
        instance = this;
        else
        Destroy(this.gameObject);
        DontDestroyOnLoad(this);
        //初始化
        Advertisement.Initialize(gameID,false,this);
    }
    public void ShowRewardAds()
    {
        Advertisement.Show(rewardPlacementID,this);
    }
    public void ShowInterAds()
    {
        Advertisement.Show(interPlacementID,this);
    
    }
    #region 初始化
    public void OnInitializationComplete()
    {
        // Debug.Log("广告初始化成功");
        //预加载 id+监听
        Advertisement.Load(rewardPlacementID,this);
        Advertisement.Load(interPlacementID,this);
    }

    public void OnInitializationFailed(UnityAdsInitializationError error, string message)
    {
        // Debug.Log("广告初始化失败"+message);
    }
    #endregion
    #region 广告加载
    public void OnUnityAdsAdLoaded(string placementId)
    {
        // Debug.Log("广告"+placementId+"加载成功");
    }

    public void OnUnityAdsFailedToLoad(string placementId, UnityAdsLoadError error, string message)
    {
        Advertisement.Initialize(gameID,testMode: false,initializationListener:this);
        OnInitializationComplete();
    }


    #endregion
    #region 广告显示
    public void OnUnityAdsShowFailure(string placementId, UnityAdsShowError error, string message)
    {
    
    }

    public void OnUnityAdsShowStart(string placementId)
    {
        //广告开始时停止音乐停止游戏时间
        Time.timeScale = 0;
        AudioManager.instance.bgmMusic.Stop();
    }
    public void OnUnityAdsShowClick(string placementId)
    {
    }

    public void OnUnityAdsShowComplete(string placementId, UnityAdsShowCompletionState showCompletionState)
    {
        //重新开始游戏
        Time.timeScale = 0.1F;
        TransitionManager.instance.Transition("Gameplay");
        //Invoke("WaitToTransition",0.5f);
        //TransitionManager.instance.TransitionNot();
        AudioManager.instance.bgmMusic.Play();
    }
    private void WaitToTransition()
    {
        Debug.Log("ok");
        
        TransitionManager.instance.Transition("Gameplay");
    }
    #endregion
}
