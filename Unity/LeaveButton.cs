using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeaveButton : MonoBehaviour
{
private Button button;
private void Awake() 
{
    button = GetComponent<Button>();
    button.onClick.AddListener(LeaveGame);
}
private void LeaveGame()
{
#if UNITY_EDITOR//在编辑器中退出
UnityEditor.EditorApplication.isPlaying = false;
#else//在游戏中退出
Application.Quit();
#endif
}
}
