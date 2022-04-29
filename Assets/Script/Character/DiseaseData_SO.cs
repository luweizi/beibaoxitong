using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Data", menuName = "Disease Data/Data")]
public class DiseaseData_SO : ScriptableObject
{
   
    public bool isDisease;//判断动物是否患有疾病
    public bool isMildSymptoms;
    public bool isModerateSymptoms;
    public bool isSevereSymptoms;
    public float illness; //生病的程度
    public int cureValue; //治愈值
    public float failoverTime;//自愈时间
    public List<int> epidemicArea;//动物疫区

}
