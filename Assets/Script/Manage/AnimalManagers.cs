using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AnimalStates //�������Ϊ
{
    NORMAL,         //������Ϊ״̬
    INWEATHER,      //����Ӱ���µ���Ϊ״̬
    DEAD            //����
}
public enum AnimalAge //���������״̬
{
    YOUNG,          //������
    ADULT,          //������
    OLD             //����
}
public enum AnimalType
{
    PIG
    //�������

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
    void SwitchAnimalType()//���ж��������ж�
    {

        switch (animalType)
        {

            case AnimalType.PIG:
                JudgeAnimalAge();
                break;
        }
    }
    void JudgeAnimalAge()//���ж��������ж�
    {
        switch (animalAge)
        {
            case AnimalAge.YOUNG://�˴�������չ����


                break;
            case AnimalAge.ADULT://ĿǰĬ��״̬
                SwitchAnimalStates();
                break;


            case AnimalAge.OLD://������չ������Ϊ����
                break;
        }
    }

    void SwitchAnimalStates()//���г�����Ϊ�ж�
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
        
        animalBehavior.AnimalRun(characterState);//����Ϊ���ڴ˴����ڸ÷����У�Ӧ���趨�����������bool�����б�
        animalBehavior.AnimalJump();
        animalBehavior.AnimalSleep();
        animalBehavior.AnimalSound();
        animalBehavior.AnimalPlayWithPlayer();
        animalBehavior.AnimalReproduction();
        Debug.Log("passtest");

        //���Ϲ�ͬ��Ϊ
        switch (animalType)
        {
            case AnimalType://���纣����
                animalBehavior.AnimalSwim();
                //��������ж�Ϊ�����ද�� animalBehavior.AnmialFly();
                break;

        }
        //����Ϊ������Ϊ    
    }
    void AnimalInWeather()
    {
        //������Ҫ���÷ֱ����Animal Behavior�ķ���
        #region ��ͨ����������Ϊ
        if (characterState.isCloudy)
        {
            Debug.Log("Today is Cloudy");//
        }
        else if (characterState.isFoggy)
        {
            if (characterState.templateAnimalData.currentImmunity <= 20)//�����ж����ж����״ֵ̬��ɸѡ���������Ķ���
            {
                animalBehavior.AnimalFallIll();//�����������Ķ����ж�Ϊ����Ⱦ��
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
            //��������չ����
        }
        else if (characterState.isBlueAroras)
        {

        }
        #endregion
        #region ĳ�ֶ��������������µ�������Ϊ
        switch (animalType)//��չ����
        {
            case AnimalType:
                if (characterState.isFoggy) //����ĳ�ֶ����ڴ����µ���Ϊ
                {
                    //���÷���
                    //��ҪgetĿ���boolֵ
                }
                break;
        }
        #endregion
    }
    void AnimalDead()
    {
        

    }
}
