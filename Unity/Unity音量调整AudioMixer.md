Unity音量调整AudioMixer

# 一、作用

在Unity中，很难对播放中的AudioClip进行调整，因此可以使用AudioMixer进行音量的调整

# 二、用法

创建AudioMixer，AudioScource中的Output可以设置AudioMixer中的音轨

在AudioMixer中，选择需要的音轨到暴露到代码中

完整代码(暴露音轨变量名为MasterValue)

```c#
using UnityEngine.Audio;
using UnityEngine;
public class AudioManager:MonoBehaviour
{
	public AudioMixer mixer;
	public void Mute(bool isOn)//通过开关传递一个布尔值
	{
        if(isOn)
		mixer.SetFloat("MasterValue",-80);
        else
        mixer.SetFloat("MasterValue",0);
	}
}
```

