using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelpManager : MonoBehaviour
{
    public static HelpManager instance;
    public Text helpText;
    public GameObject handClick;
    public GameObject handTouch;
    private bool needhelp;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
            Destroy(this.gameObject);
    }
    public void SetHelpText(string text)
    {
      helpText.text = text;
    }
    public void CloseHandClick()
    {
      handClick.SetActive(false);
    }
    public void CloseHandTouch()
    {
      handTouch.SetActive(false);
    }
    public void OpenHandClick()
    {
      handClick.SetActive(true);
    }
    public void OpenHandTouch()
    {
      handTouch.SetActive(true);
    }
}
