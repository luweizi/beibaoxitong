using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherManage : AnimalManagers
{
    //�˴�����Test����������ϵͳ���Unistorm��ȡ�������ݣ�����ͨ����������������ж�����
    //�����������ɸ�����ȣ��˴�Ϊ��Test��������
    // Start is called before the first frame update
    private int randomWeather;
    private float timeWeatherSystem = 20;
    private CharacterState characterState;
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RandomWeather()
    {
        Debug.Log("ִ��������random����");
        timeWeatherSystem = timeWeatherSystem - Time.deltaTime;
        if (timeWeatherSystem <= 0)
        {
            randomWeather = Random.Range(0, 8);
            timeWeatherSystem = 20;
        }


        if (0 <= randomWeather && randomWeather < 1)
        {
            characterState.characterWeatherData.isClear = true;
            characterState.characterWeatherData.isCloudy = false;
            characterState.characterWeatherData.isRain = false;
            characterState.characterWeatherData.isHeavyRain = false;
            characterState.characterWeatherData.isFoggy = false;
            characterState.characterWeatherData.isRedAroras = false;
            characterState.characterWeatherData.isBlueAroras = false;
            characterState.characterWeatherData.isSnow = false;
        }
        else if(1 <= randomWeather && randomWeather < 2)
        {
            characterState.characterWeatherData.isClear = false;
            characterState.characterWeatherData.isCloudy = true;
            characterState.characterWeatherData.isRain = false;
            characterState.characterWeatherData.isHeavyRain = false;
            characterState.characterWeatherData.isFoggy = false;
            characterState.characterWeatherData.isRedAroras = false;
            characterState.characterWeatherData.isBlueAroras = false;
            characterState.characterWeatherData.isSnow = false;

        }
        else if ( 2 <= randomWeather && randomWeather < 3)
        {
            characterState.characterWeatherData.isClear = false;
            characterState.characterWeatherData.isCloudy = false;
            characterState.characterWeatherData.isRain = true;
            characterState.characterWeatherData.isHeavyRain = false;
            characterState.characterWeatherData.isFoggy = false;
            characterState.characterWeatherData.isRedAroras = false;
            characterState.characterWeatherData.isBlueAroras = false;
            characterState.characterWeatherData.isSnow = false;
        }
        else if (3 <= randomWeather && randomWeather < 4)
        {
            characterState.characterWeatherData.isClear = false;
            characterState.characterWeatherData.isCloudy = false;
            characterState.characterWeatherData.isRain = false;
            characterState.characterWeatherData.isHeavyRain = true;
            characterState.characterWeatherData.isFoggy = false;
            characterState.characterWeatherData.isRedAroras = false;
            characterState.characterWeatherData.isBlueAroras = false;
            characterState.characterWeatherData.isSnow = false;
        }
        else if (4 <= randomWeather && randomWeather < 5)
        {
            characterState.characterWeatherData.isClear = false;
            characterState.characterWeatherData.isCloudy = false;
            characterState.characterWeatherData.isRain = false;
            characterState.characterWeatherData.isHeavyRain = false;
            characterState.characterWeatherData.isFoggy = true;
            characterState.characterWeatherData.isRedAroras = false;
            characterState.characterWeatherData.isBlueAroras = false;
            characterState.characterWeatherData.isSnow = false;
        }
        else if (5 <= randomWeather && randomWeather < 6)
        {
            characterState.characterWeatherData.isClear = false;
            characterState.characterWeatherData.isCloudy = false;
            characterState.characterWeatherData.isRain = false;
            characterState.characterWeatherData.isHeavyRain = false;
            characterState.characterWeatherData.isFoggy = false;
            characterState.characterWeatherData.isRedAroras = true;
            characterState.characterWeatherData.isBlueAroras = false;
            characterState.characterWeatherData.isSnow = false;
        }
        else if (6 <= randomWeather && randomWeather < 7)
        {
            characterState.characterWeatherData.isClear = false;
            characterState.characterWeatherData.isCloudy = false;
            characterState.characterWeatherData.isRain = false;
            characterState.characterWeatherData.isHeavyRain = false;
            characterState.characterWeatherData.isFoggy = false;
            characterState.characterWeatherData.isRedAroras = false;
            characterState.characterWeatherData.isBlueAroras = true;
            characterState.characterWeatherData.isSnow = false;
        }
        else if (7 <= randomWeather && randomWeather < 8)
        {
            characterState.characterWeatherData.isClear = false;
            characterState.characterWeatherData.isCloudy = false;
            characterState.characterWeatherData.isRain = false;
            characterState.characterWeatherData.isHeavyRain = false;
            characterState.characterWeatherData.isFoggy = false;
            characterState.characterWeatherData.isRedAroras = false;
            characterState.characterWeatherData.isBlueAroras = false;
            characterState.characterWeatherData.isSnow = true;
        }


    }
}
