using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelpButton : MonoBehaviour
{
private Button button;
public Text tip;
public GameObject tipObj;
private void OnEnable()
{
}
private void Awake() 
{
    button = GetComponent<Button>();
    button.onClick.AddListener(HelptToogle);
}
private void HelptToogle()
{
    //提示打开了教程
    AudioManager.instance.SetJumpClip(1);
    tipObj.SetActive(true);
    tip.text = "打开了教程";
    GameManager.instance.OnSwitchHelp();
    Invoke("SetFalse",4);
}
private void SetFalse()
{
tipObj.SetActive(false);
}
}
