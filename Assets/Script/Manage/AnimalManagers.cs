using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AnimalStates //动物的行为
{
    NORMAL,         //正常行为状态
    INWEATHER,      //天气影响下的行为状态
    DEAD            //死亡
}
public enum AnimalAge //动物的年龄状态
{
    YOUNG,          //幼年期
    ADULT,          //成熟期
    OLD             //老年
}
public enum AnimalType
{
    PIG
    //后续添加

}
public class AnimalManagers : MonoBehaviour
{
    private WeatherRandom weatherRandom;
    private AnimalBehaviors animalBehavior;
    private CharacterState characterState;
    public AnimalStates animalStates;
    public AnimalAge animalAge;
    public AnimalType animalType;
    [Header("State and animal behavior")]
    private bool isNORMAL;
    private bool isINWEATHER;
    private bool isDEAD;
    [Header("State and animal age")]
    private bool isYOUNG;
    private bool isADULT;
    private bool isOLD;

    private void Awake()
    {
        animalBehavior = GetComponent<AnimalBehaviors>();
        characterState = GetComponent<CharacterState>();
    }
    void Start()
    {    
    }
    void Update()
    {
       // animalBehavior.SwitchAnimalAnimation();
        Debug.Log("test");
        SwitchAnimalType();
       // weatherRandom.RandomWeather();

    }
    void SwitchAnimalType()//进行动物类型判断
    {

        switch (animalType)
        {

            case AnimalType.PIG:
                JudgeAnimalAge();
                break;
        }
    }
    void JudgeAnimalAge()//进行动物年龄判断
    {
        switch (animalAge)
        {
            case AnimalAge.YOUNG://此处用来拓展内容


                break;
            case AnimalAge.ADULT://目前默认状态
                SwitchAnimalStates();
                break;


            case AnimalAge.OLD://用来拓展动物行为内容
                break;
        }
    }

    void SwitchAnimalStates()//进行初步行为判断
    {
        switch (animalStates)
        {
            case AnimalStates.NORMAL:
                Debug.Log("TEST2");
                AnimalNormal();
                break;
            case AnimalStates.INWEATHER:
                AnimalInWeather();
                break;
            case AnimalStates.DEAD:
                Destroy(gameObject);
                break;
        }
    }

    void AnimalNormal()
    {
       
        animalBehavior.AnimalMove(characterState);
        
        animalBehavior.AnimalRun(characterState);//该行为放在此处，在该方法中，应该设定海洋动物和鸟类bool进行判别
        animalBehavior.AnimalJump();
        animalBehavior.AnimalSleep();
        animalBehavior.AnimalSound();
        animalBehavior.AnimalPlayWithPlayer();
        animalBehavior.AnimalReproduction();
        Debug.Log("passtest");

        //以上共同行为
        switch (animalType)
        {
            case AnimalType://例如海洋动物
                animalBehavior.AnimalSwim();
                //如果类型判断为飞行类动物 animalBehavior.AnmialFly();
                break;

        }
        //以上为特异行为    
    }
    void AnimalInWeather()
    {
        //以下需要调用分别调用Animal Behavior的方法
        #region 共通各种天气行为
        if (characterState.isCloudy)
        {
            Debug.Log("Today is Cloudy");//
        }
        else if (characterState.isFoggy)
        {
            if (characterState.templateAnimalData.currentImmunity <= 20)//首先判断所有动物的状态值，筛选符合条件的动物
            {
                animalBehavior.AnimalFallIll();//将符合条件的动物判定为初次染病
            }
        }
        else if (characterState.isRain)
        {

        }
        else if (characterState.isHeavyRain)
        {

        }
        else if (characterState.isSnow)
        {
            animalBehavior.AnimalGather();
        }
        else if (characterState.isRedAroras)
        {
            //创新性拓展内容
        }
        else if (characterState.isBlueAroras)
        {

        }
        #endregion
        #region 某种动物在特殊天气下的特殊行为
        switch (animalType)//拓展内容
        {
            case AnimalType:
                if (characterState.isFoggy) //比如某种动物在大雾下的行为
                {
                    //调用方法
                    //需要get目标的bool值
                }
                break;
        }
        #endregion
    }
    void AnimalDead()
    {
        

    }
}
