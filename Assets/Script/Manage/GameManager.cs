using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    protected override void Awake()
    {
        base.Awake();
        DontDestroyOnLoad(this);
    }
    public WeatherRandom weatherRandom;
    void Update()
    {
        weatherRandom.RandomWeather();//调用天气模块
     }
    





}
