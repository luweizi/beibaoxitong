using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalInfectiousDiseases : MonoBehaviour,IDiseaseStatus
{
    //如何实现第一只动物生病？特定天气下加初始免疫力低下
    //如果实现其余其他动物生病
    //传染病模块，动物触发感染病
    //如果动物得到了传染病，那么会传染其他同类动物，并较低概率传染非同类动物
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
    
    private void AnimalHealing()//动物痊愈
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
    void Treatment()//治疗动物
    {
        switch (medicine)
        {
            case Medicine:
                characterState.diseaseData.cureValue = characterState.diseaseData.cureValue + 20;
                break;
            default:
        }
    }

    void AnimalSymptom() //动物症状
    {
        if (characterState.diseaseData.isMildSymptoms)
        {
            //待拓展
        }
        else if (characterState.diseaseData.isModerateSymptoms)
        {
            //待拓展
        }
        else if (characterState.diseaseData.isSevereSymptoms)
        {
            //待拓展
        }
    }
    void IDiseaseStatus.CheckAnimal()
    {
        
         
    }
    void CheckAnimalConfig()
    {
       
    }


}
