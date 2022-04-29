//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.AI;
////判断天气类型，得到天气类型的bool值
//// 判断动物类型→判断动物年龄阶段→判断动物行为→具体判断
///* 动物行为的行为分为正常天气Clear的行为以及非Clear下的行为
// * 非clear天气下判断具体天气类型，然后编写具体行为
// * 动物行为分为共同行为和特异行为
// */
////以下三个枚举类型可在脚本外就行初始设置，来达到确认动物类型规范其行为的效果
//public enum AnimalStates //动物的行为
//{
//    NORMAL,         //正常行为状态
//    INWEATHER,      //天气影响下的行为状态
//    DEAD            //死亡
//}
//public enum AnimalAge //动物的年龄状态
//{
//    YOUNG,          //幼年期
//    ADULT,          //成熟期
//    OLD             //老年
//}
//public enum AnimalType
//{
//    //后续添加
    
//}
//public class AnimalManage : MonoBehaviour
//{
//    private AnimalBehavior animalBehavior;
//    private CharacterState characterState;
//    private AnimalStates animalStates;
//    private AnimalAge animalAge;
//    private AnimalType animalType;
//    [Header("State and animal behavior")]
//    private bool isNORMAL;
//    private bool isINWEATHER;
//    private bool isDEAD;
//    [Header("State and animal age")]
//    private bool isYOUNG;
//    private bool isADULT;
//    private bool isOLD;

//    private void Awake()
//    {
//        animalBehavior = GetComponent<AnimalBehavior>();
//    }
//    void Update()
//    {
//        animalBehavior.SwitchAnimalAnimation();

        
//    }
//    void SwitchAnimalType()//进行动物类型判断
//    {
        
//        switch (animalType)
//        {
            
//            case AnimalType:
//                JudgeAnimalAge();
//                break;
            
//        }
//    }
//    void JudgeAnimalAge()//进行动物年龄判断
//    {
//        switch (animalAge)
//        {
//            case AnimalAge.YOUNG://此处用来拓展内容
                
                
//                break;
//            case AnimalAge.ADULT://目前默认状态
//                SwitchAnimalStates();
//                break;


//            case AnimalAge.OLD://用来拓展动物行为内容
//                break;
//        }
//    }
  
//    void SwitchAnimalStates()//进行初步行为判断
//    {
//        switch (animalStates)
//        {
//            case AnimalStates.NORMAL:
//                AnimalNormal();
//                break;
//            case AnimalStates.INWEATHER:
//                AnimalInWeather();
//                break;
//            case AnimalStates.DEAD:
//                Destroy(gameObject);
//                break;
//        }
//    }

//    void AnimalNormal()
//    {
//        animalBehavior.AnimalMove(characterState);
//        animalBehavior.AnimalRun(characterState);//该行为放在此处，在该方法中，应该设定海洋动物和鸟类bool进行判别
//        animalBehavior.AnimalJump();
//        animalBehavior.AnimalSleep();
//        animalBehavior.AnimalSound();
//        animalBehavior.AnimalDead();
//        animalBehavior.AnimalPlayWithPlayer();
//        animalBehavior.AnimalReproduction();

//        //以上共同行为
//        switch (animalType)
//        {
//            case AnimalType://例如海洋动物
//                animalBehavior.AnimalSwim();
//                //如果类型判断为飞行类动物 animalBehavior.AnmialFly();
//                break;       
                
//        }
//        //以上为特异行为    
//    }
//    void AnimalInWeather()
//    {
//        //以下需要调用分别调用Animal Behavior的方法
//        #region 共通各种天气行为
//        if (characterState.isCloudy)
//        {
//            //
//        }
//        else if (characterState.isFoggy)
//        {
            
//        }
//        else if (characterState.isRain)
//        {

//        }
//        else if (characterState.isHeavyRain)
//        {

//        }
//        else if (characterState.isSnow)
//        {
//            animalBehavior.AnimalGather();
//        }
//        else if (characterState.isRedAroras)
//        {
//            //创新性拓展内容
//        }
//        else if (characterState.isBlueAroras)
//        {

//        }
//        #endregion
//        #region 某种动物在特殊天气下的特殊行为
//        switch (animalType)//拓展内容
//        {
//            case AnimalType:
//                if (characterState.isFoggy) //比如某种动物在大雾下的行为
//                {
//                    //调用方法
                    
//                }
//                break;
//        }
//        #endregion
//    }
//    void AnimalDead()
//    {
        
//    }
//}
