using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;


public class LightDirection : MonoBehaviour
{
    
    [SerializeField] Light sunLight;
    [SerializeField] Transform sunTransform; 
    [SerializeField] GameObject obj;
    [SerializeField] TextMeshProUGUI dateText;
    [SerializeField] TextMeshProUGUI timeText;
    [SerializeField] TextMeshProUGUI xText;
    [SerializeField] TextMeshProUGUI yText;
    public DateTime dateTime;
    float time = 24f;
    float currentTime = 0f;

    private void Update()
    {
        TransformSunlightPosition();
    }
    private void TransformSunlightPosition()
    {
        string getDate = UserInput.Instance.DateToString;
        string getTime = UserInput.Instance.TimeToString;
        if(!DateTime.TryParse(getDate + "" + getTime, out dateTime))
        {
            return;
        }
        for(int i = 0; i< time; i++)
        {
            Debug.Log("AAAA ");
            float temp = i / time * 24f;
            CalculateSunAltitude(temp, UserInput.Instance.XAxis);
            CalculateSunAzimuth(temp, UserInput.Instance.YAxis);
        }
    }
    private void CalculateSunAltitude(float time, float sunAltitude)
    {
        Debug.Log("AAAAAAAAA " + sunAltitude);
        string tempString;
        sunAltitude = 90f - (time / 24f) * 180f;
        tempString = sunAltitude.ToString() + "°";
        xText.text = $"Sun altitude: {tempString}";
    }
    private  void CalculateSunAzimuth(float time, float sunAzimuth)
    {
        string tempString;
        sunAzimuth = 180f - (time / 24f) * 360f;
        tempString = sunAzimuth.ToString() + "°";
        yText.text = $"Sun azimuth: {tempString}";
    }
}
