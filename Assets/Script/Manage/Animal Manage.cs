//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.AI;
////�ж��������ͣ��õ��������͵�boolֵ
//// �ж϶������͡��ж϶�������׶Ρ��ж϶�����Ϊ�������ж�
///* ������Ϊ����Ϊ��Ϊ��������Clear����Ϊ�Լ���Clear�µ���Ϊ
// * ��clear�������жϾ����������ͣ�Ȼ���д������Ϊ
// * ������Ϊ��Ϊ��ͬ��Ϊ��������Ϊ
// */
////��������ö�����Ϳ��ڽű�����г�ʼ���ã����ﵽȷ�϶������͹淶����Ϊ��Ч��
//public enum AnimalStates //�������Ϊ
//{
//    NORMAL,         //������Ϊ״̬
//    INWEATHER,      //����Ӱ���µ���Ϊ״̬
//    DEAD            //����
//}
//public enum AnimalAge //���������״̬
//{
//    YOUNG,          //������
//    ADULT,          //������
//    OLD             //����
//}
//public enum AnimalType
//{
//    //�������
    
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
//    void SwitchAnimalType()//���ж��������ж�
//    {
        
//        switch (animalType)
//        {
            
//            case AnimalType:
//                JudgeAnimalAge();
//                break;
            
//        }
//    }
//    void JudgeAnimalAge()//���ж��������ж�
//    {
//        switch (animalAge)
//        {
//            case AnimalAge.YOUNG://�˴�������չ����
                
                
//                break;
//            case AnimalAge.ADULT://ĿǰĬ��״̬
//                SwitchAnimalStates();
//                break;


//            case AnimalAge.OLD://������չ������Ϊ����
//                break;
//        }
//    }
  
//    void SwitchAnimalStates()//���г�����Ϊ�ж�
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
//        animalBehavior.AnimalRun(characterState);//����Ϊ���ڴ˴����ڸ÷����У�Ӧ���趨�����������bool�����б�
//        animalBehavior.AnimalJump();
//        animalBehavior.AnimalSleep();
//        animalBehavior.AnimalSound();
//        animalBehavior.AnimalDead();
//        animalBehavior.AnimalPlayWithPlayer();
//        animalBehavior.AnimalReproduction();

//        //���Ϲ�ͬ��Ϊ
//        switch (animalType)
//        {
//            case AnimalType://���纣����
//                animalBehavior.AnimalSwim();
//                //��������ж�Ϊ�����ද�� animalBehavior.AnmialFly();
//                break;       
                
//        }
//        //����Ϊ������Ϊ    
//    }
//    void AnimalInWeather()
//    {
//        //������Ҫ���÷ֱ����Animal Behavior�ķ���
//        #region ��ͨ����������Ϊ
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
//            //��������չ����
//        }
//        else if (characterState.isBlueAroras)
//        {

//        }
//        #endregion
//        #region ĳ�ֶ��������������µ�������Ϊ
//        switch (animalType)//��չ����
//        {
//            case AnimalType:
//                if (characterState.isFoggy) //����ĳ�ֶ����ڴ����µ���Ϊ
//                {
//                    //���÷���
                    
//                }
//                break;
//        }
//        #endregion
//    }
//    void AnimalDead()
//    {
        
//    }
//}
