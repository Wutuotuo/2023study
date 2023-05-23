Unity使用Newtonsoft Json实现持久数据存储

# 一、导入包

Newtonsoft Json

NewtonsoftJson是c#的一套json处理封装类，它可以高效，方便地帮助我们处理json。

![](D:\360MoveData\Users\13038\Desktop\2023study\image\Snipaste_2023-05-23_19-45-53.png)

# 二、存储信息，读取信息脚本

## 1.基础方法

```csharp
JsonConvert.DeserializeObject<T>(string json)//反序列化
JsonConvert.SerializeObject(object obj) //序列化
```

## 2.完整代码示例

```csharp
using Newtonsoft.Json;
using System.IO;
using UnityEngine;
using Syste.Collections.Generic;

public class StoreInformation : MonoBehaviour
{
    public List <int> scoreList;//分数的列表
    private int score;//得分
    private string dataPath;//存储的路径
    private void Awake()
    {
        //Application.persistentDataPath是序列化存储的路径，不同设备路径不同
        dataPath = Application.persistentDataPath + "/score.json";
        scoreList = GetScoreListData();//读取保存的文件
        //场景转换时不要销毁该物体
        DontDestroyOnLoad(this);
    }
    public void GetScore(int i)//得到分数
    {
        score = i;
    }
    public void GameOver()//游戏结束时，将不同的分数保存
    {
        if(!scoreList.Contains(score))
        {
            scoreList.Add(score);
        }
        scoreList.Sort();//排序：由小到大
        scoreList.Reverse();//倒置
        //写文件（文件路径，文件内容（序列化的列表））
        File.WriteAllText(dataPath,JsonConvert.SerializeObject(scoreList));
    }
    private List<int> GetScoreListData()
    {
        if(File.Exists(dataPath))
        {
            //读文件
            string jsonData = File.ReadAllText(dataPath);
            //读出来的数据反序列化
            return JsonConvert.DeserializeObject<List<int>>(jsonData);
        }
        return new List<int>();
    }
}
```

# 三、保存路径
Application.persistentDataPath在不同设备有不同的保存位置

Windows:	`%userprofile%\AppData\Local\Packages\<productname>\LocalState`

Linux:		`$XDG_CONFIG_HOME/unity3d/<companyname>/<productname>`

Mac:			`~/Library/Application Support/companyname/productname`

旧版本Mac:`~/Library/Application Support/unity.companyname.productname.`

Andriod:	`/Data/Data/com.<companyname>.<productname>/files`

Andriodsd卡:	`/storage/sdcard0/Android/data/com.<companyname>.<productname>/files`

IOS:			`/var/mobile/Containers/Data/Application/<RandomFolderName>/Documents`

companyname =构建设置中的公司名称

productname =构建设置中的产品名称
