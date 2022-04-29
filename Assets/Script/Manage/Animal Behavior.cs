//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class AnimalBehavior : AnimalManagers
//{

//    //该部分内容用于动物行为的编写
//    CharacterState characterState;//调用动物属性数据
//    public Animator anim;//获取动画组件
//    /*动物所需刚体等组件的内容待cr之后添加*/
//    [Header("Animation bool")]//设置bool值对状态机进行判断,此处暂时都为bool值，根据项目需求进行float等其他动画状态机条件判断
//    bool isWalk;
//    bool isRun;
//    bool isJump;
//    bool isSleep;
//    bool isFly;
//    bool isSwim;
//    bool isEat;
//    bool isReproduction;
//    bool isPlayWithPlayer;
//    bool isAnimalFear;
//    bool isAnimalGather;
//    bool isAnimalFight;

//    public void SwitchAnimalAnimation()
//    {
//        anim.SetBool("",isWalk);
//        anim.SetBool("", isRun);
//        anim.SetBool("", isJump);
//        anim.SetBool("", isSleep);
//        anim.SetBool("", isFly);
//        anim.SetBool("", isSwim);
//        anim.SetBool("", isEat);
//        anim.SetBool("", isReproduction);
//        anim.SetBool("", isPlayWithPlayer);
//        anim.SetBool("", isAnimalFear);
//        anim.SetBool("", isAnimalGather);
//        anim.SetBool("", isAnimalFight);

//    }
//    //动物行为的具体代码编写在cr之后Update
//    #region 动物基础行为zhi
//    public void AnimalMove(CharacterState characterState)//控制动物移动
//    {
//        //Update状态机数值
//       //获取目标移动范围半径
//       //随机产生半径内的X与Z值
//       //设置计时器进行重置
//       //循环该过程
//    }
//    public void AnmialFly()//控制动物飞行，飞行类动物调用该方法
//    {

//    }
//    public void AnimalRun(CharacterState characterState)//控制动物快速移动
//    {

//    }
//    public void AnimalJump()//控制动物跳跃
//    {
//        Debug.Log("enterOther");
//    }
//    public void AnimalSwim()//控制动物游泳，水族类生物调用
//    {
        
//    }
//    public void AnimalSound()//控制动物叫声
//    {
//        //设置计时器，产生一个限定时间内的随机数值
//        //数值归零后播放BGM

//    }
//    public void AnimalEat()//控制动物进食
//    {

//    }
//    public void AnimalSleep()//控制动物睡眠
//    {
//        //获取游戏内昼夜时间
//        //Update状态机进行动画覆盖

//    }
//    public void AnimalPlayWithPlayer()//控制动物与玩家的互动
//    {

//    }
//    public void AnimalReproduction()//控制动物繁殖
//    {
//        //设置限定条件
//        //更新Data数据
//        //当currentData == maxData时 Update状态机
//        //
//    }

//    #endregion
//    #region 动物在天气天下的行为
//    public void AnimalFear()//动物害怕，行为行为静止，该状态可应用于雷雨天气
//    {
        
//    }
//    public void AnimalGather() //动物聚集，可应用于下雪天
//    {
        
//    }
//    public void AnimalSpecialSound()//动物特殊叫声，在雨天或者其他天气时调用
//    {
        
//    }
//    public void AnimalFight()//动物打架
//    {
        
//    }
//    public void AnimalTest()
//    {
//        Debug.Log("Test");
//    }


//    #endregion
    

//}
