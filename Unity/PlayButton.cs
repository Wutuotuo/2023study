using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
private Button button;
private void Awake() 
{
    button = GetComponent<Button>();
    button.onClick.AddListener(StartGame);
}
private void StartGame()
{
    //启动游戏加载场景
    //SceneManager.LoadScene("Gameplay");
    TransitionManager.instance.Transition("Gameplay");
}
}
