//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class AnimalBehavior : AnimalManagers
//{

//    //�ò����������ڶ�����Ϊ�ı�д
//    CharacterState characterState;//���ö�����������
//    public Animator anim;//��ȡ�������
//    /*��������������������ݴ�cr֮�����*/
//    [Header("Animation bool")]//����boolֵ��״̬�������ж�,�˴���ʱ��Ϊboolֵ��������Ŀ�������float����������״̬�������ж�
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
//    //������Ϊ�ľ�������д��cr֮��Update
//    #region ���������Ϊzhi
//    public void AnimalMove(CharacterState characterState)//���ƶ����ƶ�
//    {
//        //Update״̬����ֵ
//       //��ȡĿ���ƶ���Χ�뾶
//       //��������뾶�ڵ�X��Zֵ
//       //���ü�ʱ����������
//       //ѭ���ù���
//    }
//    public void AnmialFly()//���ƶ�����У������ද����ø÷���
//    {

//    }
//    public void AnimalRun(CharacterState characterState)//���ƶ�������ƶ�
//    {

//    }
//    public void AnimalJump()//���ƶ�����Ծ
//    {
//        Debug.Log("enterOther");
//    }
//    public void AnimalSwim()//���ƶ�����Ӿ��ˮ�����������
//    {
        
//    }
//    public void AnimalSound()//���ƶ������
//    {
//        //���ü�ʱ��������һ���޶�ʱ���ڵ������ֵ
//        //��ֵ����󲥷�BGM

//    }
//    public void AnimalEat()//���ƶ����ʳ
//    {

//    }
//    public void AnimalSleep()//���ƶ���˯��
//    {
//        //��ȡ��Ϸ����ҹʱ��
//        //Update״̬�����ж�������

//    }
//    public void AnimalPlayWithPlayer()//���ƶ�������ҵĻ���
//    {

//    }
//    public void AnimalReproduction()//���ƶ��ﷱֳ
//    {
//        //�����޶�����
//        //����Data����
//        //��currentData == maxDataʱ Update״̬��
//        //
//    }

//    #endregion
//    #region �������������µ���Ϊ
//    public void AnimalFear()//���ﺦ�£���Ϊ��Ϊ��ֹ����״̬��Ӧ������������
//    {
        
//    }
//    public void AnimalGather() //����ۼ�����Ӧ������ѩ��
//    {
        
//    }
//    public void AnimalSpecialSound()//������������������������������ʱ����
//    {
        
//    }
//    public void AnimalFight()//������
//    {
        
//    }
//    public void AnimalTest()
//    {
//        Debug.Log("Test");
//    }


//    #endregion
    

//}
