using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N_Calculator : MonoBehaviour
{
    public enum InputType
    {
        Number,
        Add,
        Subtract,
        Multiply,
        Devide,
        Clear,
    }

    public class StepInput
    {
        public double InputData;
        public InputType inputType;
    }

    public string tempInput;
    public List<StepInput> stepInputList = new List<StepInput>();

    public delegate void DelegateHandle(string input);
    public DelegateHandle OnInput;

    public static N_Calculator instance;

    void Awake()
    {
        instance = this;
    }
    
    public void Input(string inputStr)
    {
        StepInput newStepInput = GetStepInputFromString(inputStr);
        if (stepInputList.Count > 0)
        {
            int lastIndex = stepInputList.Count - 1;
            if (stepInputList[lastIndex].inputType == InputType.Number)
            {
                if(newStepInput.inputType == InputType.Number)
                {
                    stepInputList[lastIndex].InputData *= 10;
                    if (newStepInput.InputData != 0)
                    {
                        stepInputList[lastIndex].InputData += newStepInput.InputData;
                    }
                    Debug.Log(stepInputList[lastIndex].InputData);

                    if (OnInput != null)
                    {
                        OnInput(stepInputList[lastIndex].InputData.ToString());
                    }
                }
                else
                {
                    stepInputList.Add(newStepInput);
                }
            }
            else
            {
                if (newStepInput.inputType != InputType.Number)
                {
                    stepInputList[lastIndex].inputType = newStepInput.inputType;
                }
                else
                {
                    stepInputList.Add(newStepInput);
                }

                if (OnInput != null)
                {
                    OnInput(newStepInput.InputData.ToString());
                }
            }
        }
        else
        {
            stepInputList.Add(newStepInput);
            if (OnInput != null)
            {
                OnInput(newStepInput.InputData.ToString());
            }
        }
    }

    public void Enter()
    {
        double result = 0.0f;
        for (int i = 0; i < stepInputList.Count; i++)
        {
            var stepInput = stepInputList[i];
            switch (stepInput.inputType)
            {
                case InputType.Number:
                    {
                        result = stepInput.InputData;
                        break;
                    }
                case InputType.Add:
                    {
                        i++;
                        if (i < stepInputList.Count)
                        {
                            result += stepInputList[i].InputData;
                        }
                        break;
                    }
                case InputType.Subtract:
                    {
                        i++;
                        if (i < stepInputList.Count)
                        {
                            result -= stepInputList[i].InputData;
                        }
                        break;
                    }
                case InputType.Multiply:
                    {
                        i++;
                        if (i < stepInputList.Count)
                        {
                            result *= stepInputList[i].InputData;
                        }
                        break;
                    }
                case InputType.Devide:
                    {
                        i++;
                        if (i < stepInputList.Count)
                        {
                            result /= stepInputList[i].InputData;
                        }
                        break;
                    }
            }
        }

        stepInputList.Clear();
        stepInputList.Add(GetStepInputFromString(result.ToString()));

        OnInput(result.ToString());
    }

    public void Clear()
    {
        Debug.Log("Clear");
        stepInputList.Clear();
        N_Calculator.instance.Input("");
    }

    public void Negate()
    {
        Debug.Log("Negate Number");
    }

    private StepInput GetStepInputFromString(string inputStr)
    {
        double convertToNum = 0;
        bool isNum = double.TryParse(inputStr, out convertToNum);

        StepInput newStepInput = new StepInput();

        if (isNum)
        {
            newStepInput.inputType = InputType.Number;
            newStepInput.InputData = convertToNum;
        }
        else
        {
            if (inputStr == "+")
            {
                newStepInput.inputType = InputType.Add;
            }
            else if (inputStr == "-")
            {
                newStepInput.inputType = InputType.Subtract;
            }
            else if(inputStr == "*")
            {
                newStepInput.inputType = InputType.Multiply;
            }
            else if (inputStr == "/")
            {
                newStepInput.inputType = InputType.Devide;
            }
        }

        return newStepInput;
    }
}
