using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class N_CalculatorUI : MonoBehaviour
{
    public Text displayText;
    float timer = 1.0f;

    void Start()
    {
        N_Calculator.instance.OnInput += OnInput;
    }

    void Update()
    {
        //ColorTimer();
    }

    public void OnInput(string input)
    {
        Debug.Log(input);
        displayText.text = input;

        //Color newColor = new Color(Random.value, Random.value, Random.value);
        //displayText.color = newColor;
    }

    public void ColorTimer()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            displayText.color = Color.white;
            timer = 1.0f;
        }
    }
}
