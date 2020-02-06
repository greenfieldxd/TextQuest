﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextQuestGame : MonoBehaviour
{
    [Header("Elements")]
    public Text titleText;
    public Text contentText;
    

    [Header("Config")]
    public string text = "Game Title";
    public int titleTextSize = 30;
    public Step activeStep;

    // Start is called before the first frame update
    void Start()
    {
        titleText.text = text;
        contentText.text = activeStep.content;

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            CheckPress(0);
        }

        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            CheckPress(1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            CheckPress(2);
        }
        
      
    }

    void CheckPress(int index)
    {
        if (activeStep.nextSteps.Length > index)
        {
            if (activeStep.nextSteps[index] != null)
            {
                activeStep = activeStep.nextSteps[index];
                contentText.text = activeStep.content;
            }
        }
    }

}
