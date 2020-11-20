using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomColorControl : MonoBehaviour
{
    public static RandomColorControl instance;
    public Text[] buttonList;

    private List<Color> text = new List<Color>();
    float timer = 1.0f;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        for (int i = 0; i < buttonList.Length; i++)
        {
            buttonList[i].color = Color.black;
        }
    }

    private void Update()
    {
        ColorTimer();
    }

    public void ChangeColor(int textColor)
    {
        Color newColor = new Color(Random.value, Random.value, Random.value);
        buttonList[textColor].color = newColor;
    }

    public void ColorTimer()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            for (int i = 0; i < buttonList.Length; i++)
            {
                buttonList[i].color = Color.black;
                timer = 1.0f;
            }
        }
    }
}
