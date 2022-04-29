using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Data", menuName = "Disease Data/Data")]
public class DiseaseData_SO : ScriptableObject
{
   
    public bool isDisease;//�ж϶����Ƿ��м���
    public bool isMildSymptoms;
    public bool isModerateSymptoms;
    public bool isSevereSymptoms;
    public float illness; //�����ĳ̶�
    public int cureValue; //����ֵ
    public float failoverTime;//����ʱ��
    public List<int> epidemicArea;//��������

}
