using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leaderboard : MonoBehaviour
{
    public List<ScoreRecord> scoreRecords;
    public List<int> scoreList;
    //OnEnable会在Start之前执行
    private void OnEnable()
    {
        scoreList = GameManager.instance.GetScoreListData();
    }
    
    private void Start() {
        SetLeaderBoardData();
    }
    public void SetLeaderBoardData()
    {
    //赋值
        for(int i = 0;i<scoreRecords.Count;i++)
        {
            if(i < scoreList.Count)
            {
                scoreRecords[i].SetScoreText(scoreList[i]);
                scoreRecords[i].gameObject.SetActive(true);
            }
            else{scoreRecords[i].gameObject.SetActive(false);}
        }
    }

}
