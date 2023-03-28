using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    //设计单例模式便于其他类播放音效
    public static AudioManager instance;
    [Header("Audio Mixer")]
    public AudioMixer audioMixer;

    [Header("Audio Clips")]
    public AudioClip bgmClip;
    public AudioClip jumpClip;

    public AudioClip longJumpClip;

    public AudioClip deadClip;
    [Header("bgm")]
    public AudioSource bgmMusic;
    public AudioSource fx;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
            Destroy(this.gameObject);
        DontDestroyOnLoad(this);
        bgmMusic.clip = bgmClip;
        PlayMusic();
    }
    
    public void SetJumpClip(int type)// 0 为小跳，1是大跳
    {
        switch (type)
            {
                case 0:
                    fx.clip = jumpClip;
                    break;
                case 1:
                    fx.clip = longJumpClip;
                    break;
            }
        
    }
    private void OnEnable() {
        EventHandler.GameOverEvent += OnGameOverEvent;
    }

    private void OnGameOverEvent()
    {
        fx.clip = deadClip;
        fx.Play();
    }

    private void OnDisable() {
        EventHandler.GameOverEvent -= OnGameOverEvent;
    }
    public void PlayJumpFX()
    {
        fx.Play(); 
    }
    public void PlayMusic()
    {
        if(!bgmMusic.isPlaying)
        {
        //FIXME播放音效显示false
        //Debug.Log(bgmMusic.isPlaying);
        bgmMusic.Play();
        //Debug.Log(bgmMusic.isPlaying);
        }
    }
    public void ToggleAudio(bool isOn)
    {
        if(isOn)
        {
            audioMixer.SetFloat("MasterVolume",0);
        }
        else
        {
            audioMixer.SetFloat("MasterVolume",-80);
        }
    }
}
