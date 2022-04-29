using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Data", menuName = "Animal Stats/Data")]
public class AnimalData_SO : ScriptableObject
{
    private float timeUpdate;

    public float speed;     //动物的移动速度
    public float flySpeed; //动物的飞行速度
    public float swimSpeed; //动物游泳速度
    public float runSpeed; //动物的跑步速度
    public float jumpSpeed; //动物的跳跃速度
    public float currentImmunity; //动物的当前免疫力
    public float maxImmunity; //动物的极限免疫力

    public int maxFavorability; //好感度
    public int currentFavorability;//当前好感度
    public int maxHealth;      //生命值
    public int currentHealth;   //当前生命值
    public int maxStarvationValue; //饥饿值
    public int currentStarvationValue; //当前饥饿值
    public int maxThirstValue; //口渴值
    public int currentThirstValue;//当前口渴值
    public int maxGrowthValue;  //成长值
    public int currentGrowthValue; //当前成长值
    public int maxWeatherInfluence; //天气影响值
    public int currentWeatherInfluence;//当前影响值
    public int maxLoveValue;           //爱心值
    public int currentLoveValue;        //当前爱心值

    void MakeFullill()
    {
        if (currentImmunity <= maxImmunity)
        {
            
        }
    }
}
