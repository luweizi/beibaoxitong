using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterState : MonoBehaviour
{
    //该部分控制每一个动物的属性
    public GameObject weatherType;
    public AnimalData_SO templateAnimalData;
    public AnimalData_SO updateAnimalDate;
    public WeatherData_SO characterWeatherData;
    public DiseaseData_SO diseaseData;
    private float timeDownill = 20;
    private void Awake()
    {
        if (updateAnimalDate != null) 
        {
            templateAnimalData = Instantiate(updateAnimalDate);
        }
    }

    #region 加载animal数据
    public float speed
    {
        get { if (templateAnimalData != null) { return templateAnimalData.speed; } else { return 0; } }
        set { templateAnimalData.speed = value; }
    }
    public float flySpeed
    {
        get { if (templateAnimalData != null) { return templateAnimalData.flySpeed; } else { return 0; } }
        set { templateAnimalData.flySpeed = value; }
    }
    
    public float swimSpeed
    {
        get { if (templateAnimalData != null) { return templateAnimalData.swimSpeed; } else { return 0; } }
        set { templateAnimalData.swimSpeed = value; }
    }
    public float jumpSpeed
    {
        get { if (templateAnimalData != null) { return templateAnimalData.jumpSpeed; } else { return 0; } }
        set { templateAnimalData.jumpSpeed = value; }
    }
    public float runSpeed
    {
        get { if (templateAnimalData != null) { return templateAnimalData.runSpeed; } else { return 0; } }
        set { templateAnimalData.runSpeed = value; }
    }
    public int maxFavorability
    {
        get {if (templateAnimalData != null){return templateAnimalData.maxFavorability;}else{return 0;}}
        set {templateAnimalData.maxFavorability = value;}
    }
    public int currentFavorability
    {
        get { if (templateAnimalData != null) { return templateAnimalData.currentFavorability; } else { return 0; } }
        set { templateAnimalData.currentFavorability = value; }
    }
    public int maxHealth
    {
        get { if (templateAnimalData != null) { return templateAnimalData.maxHealth; } else { return 0; } }
        set { templateAnimalData.maxHealth = value; }
    }
    public int currentHealth
    {
        get { if (templateAnimalData != null) { return templateAnimalData.currentHealth; } else { return 0; } }
        set { templateAnimalData.currentHealth = value; }
    }
    public int maxStarvationValue
    {
        get { if (templateAnimalData != null) { return templateAnimalData.maxStarvationValue; } else { return 0; } }
        set { templateAnimalData.maxStarvationValue = value; }
    }
    public int currentStarvationValue
    {
        get { if (templateAnimalData != null) { return templateAnimalData.currentStarvationValue; } else { return 0; } }
        set { templateAnimalData.currentStarvationValue = value; }
    }
    public int maxThirstValue
    {
        get { if (templateAnimalData != null) { return templateAnimalData.maxThirstValue; } else { return 0; } }
        set { templateAnimalData.maxThirstValue = value; }
    }
    public int currentThirstValue
    {
        get { if (templateAnimalData != null) { return templateAnimalData.currentThirstValue; } else { return 0; } }
        set { templateAnimalData.currentThirstValue = value; }
    }
    public int maxGrowthValue
    {
        get { if (templateAnimalData != null) { return templateAnimalData.maxGrowthValue; } else { return 0; } }
        set { templateAnimalData.maxGrowthValue = value; }
    }
    public int currentGrowthValue
    {
        get { if (templateAnimalData != null) { return templateAnimalData.currentGrowthValue; } else { return 0; } }
        set { templateAnimalData.currentGrowthValue = value; }
    }
    public int maxWeatherInfluence
    {
        get { if (templateAnimalData != null) { return templateAnimalData.maxWeatherInfluence; } else { return 0; } }
        set { templateAnimalData.maxWeatherInfluence = value; }
    }
    public int currentWeatherInfluence
    {
        get { if (templateAnimalData != null) { return templateAnimalData.currentWeatherInfluence; } else { return 0; } }
        set { templateAnimalData.currentWeatherInfluence = value; }
    }
    public int maxLoveValue
    {
        get { if (templateAnimalData != null) { return templateAnimalData.maxLoveValue; } else { return 0; } }
        set { templateAnimalData.maxLoveValue = value; }
    }
    public int currentLoveValue
    {
        get { if (templateAnimalData != null) { return templateAnimalData.currentLoveValue; } else { return 0; } }
        set { templateAnimalData.currentLoveValue = value; }
    }
    #endregion
    #region 加载weather数据
    public bool isclear
    {
        get { if (characterWeatherData != null) { return characterWeatherData.isClear; } else { return false; } }
        set { characterWeatherData.isClear = value; }
    }
    public bool isCloudy
    {
        get { if (characterWeatherData != null) { return characterWeatherData.isCloudy; } else { return false; } }
        set { characterWeatherData.isCloudy = value; }
    }
    public bool isRain
    {
        get { if (characterWeatherData != null) { return characterWeatherData.isRain; } else { return false; } }
        set { characterWeatherData.isRain = value; }
    }
    public bool isHeavyRain
    {
        get { if (characterWeatherData != null) { return characterWeatherData.isHeavyRain; } else { return false; } }
        set { characterWeatherData.isHeavyRain = value; }
    }
    public bool isSnow
    {
        get { if (characterWeatherData != null) { return characterWeatherData.isSnow; } else { return false; } }
        set { characterWeatherData.isSnow = value; }
    }
    public bool isFoggy
    {
        get { if (characterWeatherData != null) { return characterWeatherData.isFoggy; } else { return false; } }
        set { characterWeatherData.isFoggy = value; }
    }
    public bool isRedAroras
    {
        get { if (characterWeatherData != null) { return characterWeatherData.isRedAroras; } else { return false; } }
        set { characterWeatherData.isRedAroras = value; }
    }
    public bool isBlueAroras
    {
        get { if (characterWeatherData != null) { return characterWeatherData.isBlueAroras; } else { return false; } }
        set { characterWeatherData.isBlueAroras = value; }
    }
    #endregion
    #region DiseaseDate_SO
    public float Illness
    {
        get { if (diseaseData != null) { return diseaseData.illness; } else { return 0; } }
        set { diseaseData.illness = value; }
    }
    public int cureValue
    {
        get { if (diseaseData != null) { return diseaseData.cureValue; } else { return 0; } }
        set { diseaseData.cureValue = value; }
    }
    public float failoverTime
    {
        get { if (diseaseData != null) { return diseaseData.failoverTime; } else { return 0; } }
        set { diseaseData.failoverTime = value; }
    }
    public bool isDisease
    {
        get { if (diseaseData != null) { return diseaseData.isDisease; } else { return false; } }
        set { diseaseData.isDisease = value; }
    }
    public bool isMildSymptoms
    {
        get { if (diseaseData != null) { return diseaseData.isMildSymptoms; } else { return false; } }
        set { diseaseData.isMildSymptoms = value; }
    }
    public bool isModerateSymptoms
    {
        get { if (diseaseData != null) { return diseaseData.isModerateSymptoms; } else { return false; } }
        set { diseaseData.isModerateSymptoms = value; }
    }
    public bool isSevereSymptoms
    {
        get { if (diseaseData != null) { return diseaseData.isSevereSymptoms; } else { return false; } }
        set { diseaseData.isSevereSymptoms = value; }
    }
    public List<int> epidemicArea
    {
        get { if (diseaseData != null) { return diseaseData.epidemicArea; } else { return null; } }
        set { diseaseData.epidemicArea = value; }
    }
    #endregion

    public void lifeDownInill()
    {
        timeDownill = timeDownill - Time.deltaTime;
        if (timeDownill <= 20)
        {
            templateAnimalData.currentImmunity = templateAnimalData.currentImmunity - 1;
            templateAnimalData.currentHealth = templateAnimalData.currentHealth - 1;
            timeDownill = 20;
        }      
    }
 
}
