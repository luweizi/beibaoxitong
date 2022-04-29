using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalInfectiousDiseases : MonoBehaviour,IDiseaseStatus
{
    //���ʵ�ֵ�һֻ�����������ض������¼ӳ�ʼ����������
    //���ʵ������������������
    //��Ⱦ��ģ�飬���ﴥ����Ⱦ��
    //�������õ��˴�Ⱦ������ô�ᴫȾ����ͬ�ද����ϵ͸��ʴ�Ⱦ��ͬ�ද��
    public enum Medicine
    {
        
    }
    private Medicine medicine;
    private CharacterState characterState;
    private AnimalBehaviors animalBehaviors;
    public bool animalIsIll;

    void isDiseases()
    {
        if (animalIsIll)
        {
            animalBehaviors.AnimalFallIll();
            
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Virus")
        {
            animalIsIll = true;

            if (animalBehaviors.characterState.templateAnimalData.currentImmunity >= 20 &&animalBehaviors.characterState.templateAnimalData.currentImmunity <= 50)
            {
                isDiseases();
            }
            else
            {
                return;
            }
        }
    }
    
    private void AnimalHealing()//����Ȭ��
    {
        if (characterState.diseaseData.cureValue == 100)
        {
            characterState.diseaseData.isDisease = false;
        }
        else if (characterState.diseaseData.failoverTime ==0)
        {
            characterState.diseaseData.isDisease = false;
        }
    }

    void AnimalDiseaseDegree()
    {
        if (characterState.diseaseData.isDisease == true)
        {
            
        }
    }
    void AnimalDiseaseDegreeData()
    {
        if (0 < characterState.diseaseData.illness && characterState.diseaseData.illness <= 33)
        {
            characterState.diseaseData.isMildSymptoms = true;
            characterState.diseaseData.isModerateSymptoms = false;
            characterState.diseaseData.isSevereSymptoms = false;
            AnimalSymptom();
        }
        else if (33 < characterState.diseaseData.illness && characterState.diseaseData.illness <= 66)
        {
            characterState.diseaseData.isMildSymptoms = false;
            characterState.diseaseData.isModerateSymptoms = true;
            characterState.diseaseData.isSevereSymptoms = false;
            AnimalSymptom();
        }
        else if (66 < characterState.diseaseData.illness && characterState.diseaseData.illness <= 99)
        {
            characterState.diseaseData.isMildSymptoms = false;
            characterState.diseaseData.isModerateSymptoms = false;
            characterState.diseaseData.isSevereSymptoms = true;
            AnimalSymptom();
        }
        else
        {
            
        }
             
    }
    void Treatment()//���ƶ���
    {
        switch (medicine)
        {
            case Medicine:
                characterState.diseaseData.cureValue = characterState.diseaseData.cureValue + 20;
                break;
            default:
        }
    }

    void AnimalSymptom() //����֢״
    {
        if (characterState.diseaseData.isMildSymptoms)
        {
            //����չ
        }
        else if (characterState.diseaseData.isModerateSymptoms)
        {
            //����չ
        }
        else if (characterState.diseaseData.isSevereSymptoms)
        {
            //����չ
        }
    }
    void IDiseaseStatus.CheckAnimal()
    {
        
         
    }
    void CheckAnimalConfig()
    {
       
    }


}
