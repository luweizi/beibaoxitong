# 牧场模拟项目
![](https://github.com/TwilightMoonLake/This-onetest/blob/main/GitOther/%E8%AE%BE%E8%AE%A1%E6%A8%A1%E5%9D%97%E8%8D%89%E5%9B%BE.png?raw=true)


                           
结构图如上，可能因浏览器原因无法显示
## 1.天气系统
### 插件的使用：
Unistrom天气控制插件的应用，内置管理板块和大量的天气系统，高效快速的帮助建立牧场的外部环境，本次应用的该项目的天气为晴天，多云，雨天，暴雨，雪，雾，红色极光与蓝色极光，完成昼夜时间的更迭与天气的变换。
### 环境的模拟：RandomWeather
此处的天气判定非调用Unistorm内实时天气，而是通过RandomWeather进行模拟

`private float timeWeatherSystem = 20; `

` timeWeatherSystem = timeWeatherSystem - Time.deltaTime;`


RandomWeather来产生天气bool值模拟判断

`privite RandomWeather randomWeather; ` 

## 2.动物管理模块
### 设计思路：
此处分为Animal Manage，Animal Behavior
1.创建Data模板，以此创建动物基本数据，包括生命值，好感度，移动速度，成长值等int或float型数据。
2.创建CharacteStat脚本，用来记录与调用数据，同时完成数值的计算
3.创建Animal Manage动物管理脚本，实现动物行为功能：判断顺序为：判断动物类型→判断动物年龄→判断动物行为
三个部分写三个枚举，分别用来作为记录各部分的标准
动物行为分为Clear天气下的正常行为，以及非Claer下各种特殊天气下的行为。其中，动物拥有部分的共同行为，也拥有该物种的特殊行为。并且，在特殊天气下，某种动物会产生有别于其他动物的特殊行为。
动物的各种行为分别写成方法，在判断语句判定动物种类，年龄，天气后调用。

调用有关动物的CharacterState的两部分数据

`CharacterState characterState;`

`characterState.characterWeatherData.{isClear,isCloudy...}`

`characterState.templateAnimalData.{speed,maxHealth...}`

调用动物行为的方法

`private AnimalBehavior animalBehavior;`

`animalBehavior.{AnimalMove,AnimalRun,AnimalSleep...}`
待补充

## 动物传染病模块
### 动物在特定天气下生病，该状态为传染机制。初始染病动物免疫力低于指定值时在天气作用下调用染病方法,对特定区域范围的内同类动物较高概率传染，对非同类动物进行较低概率传染。
感染机制：animal在天气状态染病后，将会实例化virus实体
`Instantiate(animalVirus,transform.position,Quaternion.identity);`
所有Animal都挂有传染模块AnimalInfectiousDiseases,该模块脚本中OnTriggerStay对范围内的进行tag检测，当检测时virus，预设bool值变为true，调用isDiseases()方法，从而调用数值计算，低于指定值后最终调用AnimalFallIll()进行染病处理。
·增加了DiscaseData集中config数据
·增加了疾病下的机制：疾病程度，疾病治疗等
·返回索引gameObject的状态
创建了接口

`public interface IDiseaseStatus `
实现接口
`void IDiseaseStatus CheckAnimal`


` private float illRadius = 10;//疾病的传染范围`

`var colliders = Physics.OverlapSphere(transform.position,illRadius);`

通过OverlapSphere获取目前区域内的动物数据，查找动物实体,调用动物传染病模块,根据时间对同类和非同类动物进行周期性的免疫力衰减，当指定值到达时调用

`animalBehaviors. AnimalFallIll();`


此处用应用OnTriggerStay进行检测t另类test

即
`if(other.tag == gameObject.tag)`

`if(other.tag != gameObject.tag)`

进行同类和非同类动物检测，然后random float数值，通过选择结构对other物体进行销毁


***
***
# 备注
## 


