using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;


public class LightDirection : MonoBehaviour
{
    float time;
    float currentTime;
    int days;
    public float speed;
    [SerializeField] Light sunLight;
    [SerializeField] Transform sunTransform; 
    [SerializeField] GameObject obj;
    [SerializeField] TextMeshProUGUI dateText;
    [SerializeField] TextMeshProUGUI timeText;
    [SerializeField] TextMeshProUGUI xText;
    [SerializeField] TextMeshProUGUI yText;

    [SerializeField] TMP_InputField inputDate;
    [SerializeField] TMP_InputField inputTime;
    [SerializeField] TMP_InputField inputX;
    [SerializeField] TMP_InputField inputY;
    float xAxis;
    float yAxis;
    string dateToString;
    string timeToString;


    private void Start()
    {
        inputDate.onValueChanged.AddListener(OnDateChange);
        inputTime.onValueChanged.AddListener(OnTimerChange);
        inputX.onValueChanged.AddListener(OnXAxisChange);
        inputY.onValueChanged.AddListener(OnYAxisChange);
    }
    private void Update()
    {
        UpdateDateTime();
    }

    private void UpdateDateTime()
    {
        sunTransform.Rotate(sunTransform.rotation.x , sunTransform.rotation.x , speed);
        Debug.Log("@@@AAAAA " + sunTransform.rotation.x);
    }
    private void OnDateChange(string userInput)
    {
        dateToString = userInput;
    }
    private void OnTimerChange(string userInput)
    {
        timeToString = userInput;
    }
    private void OnXAxisChange(string userInput)
    {
        if(float.TryParse(userInput, out float result))
        {
            xAxis = result;
            
        }
    }
    private void OnYAxisChange(string userInput)
    {
        if (float.TryParse(userInput, out float result))
        {
            yAxis = result;
        }
    }
}
