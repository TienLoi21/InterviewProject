using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UserInput : MonoBehaviour
{
    [SerializeField] TMP_InputField inputDate;
    [SerializeField] TMP_InputField inputTime;
    [SerializeField] TMP_InputField inputX;
    [SerializeField] TMP_InputField inputY;

    public float XAxis { get; private set; }
    public float YAxis { get; private set; }
    public string DateToString { get; private set; }
    public string TimeToString { get; private set; }
    public static UserInput Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        inputDate.onValueChanged.AddListener(OnDateChange);
        inputTime.onValueChanged.AddListener(OnTimerChange);
        inputX.onValueChanged.AddListener(OnXAxisChange);
        inputY.onValueChanged.AddListener(OnYAxisChange);
    }
    private void OnDateChange(string userInput)
    {
        DateToString = userInput;
    }
    private void OnTimerChange(string userInput)
    {
        TimeToString = userInput;
    }
    private void OnXAxisChange(string userInput)
    {
        if (float.TryParse(userInput, out float result))
        {
            XAxis = result;
        }
    }
    private void OnYAxisChange(string userInput)
    {
        if (float.TryParse(userInput, out float result))
        {
            YAxis = result;
        }
    }
}
