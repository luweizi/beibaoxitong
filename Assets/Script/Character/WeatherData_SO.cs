using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Data", menuName = "Weather Data/Data")]

public class WeatherData_SO : ScriptableObject
{
    public bool isClear;

    public bool isCloudy;

    public bool isRain;

    public bool isHeavyRain;

    public bool isSnow;

    public bool isFoggy;

    public bool isRedAroras;

    public bool isBlueAroras;
}
