Unity卡通射击的实现

# 控制

- 控制方式采用了角色控制器CharacterController。TransformTranslate直接移动但是没有物理碰撞，Rigidbody+Capsule符合物理学但是无法滞空运动，CharacterController可以有较多的API去实现角色的运动。

# 游戏

- 通过接口实现枪械多态化，以IWeapon武器接口延伸出抽象枪类，然后突击步枪，手枪等类直接继承抽象枪类，通过override重写方法，可以实现枪的功能有：

  1.射击（子弹池，标签检测子弹是否碰到物体，产生弹坑特效和射击音效）

  2.换弹（检测是否完成换弹再执行操作）

  3.机瞄和切换不同瞄具（装备配件后的武器瞄准发生变化）

  5.切换武器

  6.后坐力（垂直后坐力和水平后坐力，通过两个曲线图来控制时间和后坐力的关系）

  7.散射（从枪口射击出一个圆形的范围）

- 通过类WeaponManager来管理用户输入和枪械之间的关系；
  
- 通过类GameEvent来管理剧情；
  
- 通过类NPCcontrol来控制NPC行为（用到了UnityAI导航工具NavMesh）。

# 界面

- 使用Make It Flow制作了部分UI（开始界面），使用图形和文字，脚本实现了：

  1.准星UI弹夹数量UI（检测当前是否携带枪支，携带枪支的子弹数量）

  2.切枪UI（切换对应枪械时对应UI发生大小改变）

  3.剧情对话UI（使用协程打字机模式输出对话内容，NPC面向玩家）

  4.血量显示UI（检测子弹是否撞击，世界空间并且面向玩家）

# 动画

- 部分动画使用了混合树，通过速度变化范围，改变行走的动画。同时使用触发器，布尔值等来控制射击，装弹等动画。

# 音效

- 音效管理采用了资源的序列化，使角色走在不同的地面上播放不同的音效（速度控制快慢），子弹射击到不同材质的物体上时播放不同的音效。

