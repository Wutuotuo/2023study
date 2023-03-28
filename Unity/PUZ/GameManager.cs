using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Newtonsoft.Json;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public List<int> scoreList;
    private int score;
    private bool needhelp;
    private string dataPath;
    private string helpPath;
    private void Awake() {
        dataPath = Application.persistentDataPath+"/leaderboard.json";
        helpPath = Application.persistentDataPath+"/help.json";
        scoreList = GetScoreListData();
        if(instance == null)
        {
            instance = this;
        }
        else
            Destroy(this.gameObject);
        DontDestroyOnLoad(this);
    }
    private void OnEnable()
    {
        EventHandler.GameOverEvent += OnGameOverEvent;
        EventHandler.GetPointEvent += OnGetPointEvent;//注册函数的参数必须和方法相同
    }
    private void OnDisable() {
        EventHandler.GameOverEvent -= OnGameOverEvent;
        EventHandler.GetPointEvent -= OnGetPointEvent;
    }
    private void OnGetPointEvent(int point)
    {
        score = point;
    }
    private void OnGameOverEvent()
    {
        //在List中添加新的分数，排序
        //判断是否包含相同分数
        if(!scoreList.Contains(score))
        {
            scoreList.Add(score);
        }
        scoreList.Sort();
        scoreList.Reverse();
        //序列化
        File.WriteAllText(dataPath,JsonConvert.SerializeObject(scoreList));
        File.WriteAllText(helpPath,JsonConvert.SerializeObject(needhelp));
    }
    public void OnSwitchHelp()
    {
        File.WriteAllText(helpPath,JsonConvert.SerializeObject(true));
    }
    //读取保存数据的记录
    public List<int> GetScoreListData()
    {
        if(File.Exists(dataPath))
        {
            string jsonData = File.ReadAllText(dataPath);
            //反序列化
            return JsonConvert.DeserializeObject<List<int>>(jsonData);
        }
        return new List<int>();
    }
    public bool GetNeedHelpData()
    {
        if(File.Exists(helpPath))
        {
            string jsonData = File.ReadAllText(helpPath);
            //反序列化
            return JsonConvert.DeserializeObject<bool>(jsonData);
        }
        return true;
    }
}
