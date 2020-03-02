using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MobileVersionTextQuest : MonoBehaviour
{

    [Header("Elements")]
    public Text titleText;
    public Text contentText;
    public Text locationText;
    public Image locationImage;
    public Button[] buttons;


    [Header("Config")]
    public string text = "Четвертая планета";
    public int titleTextSize = 30;

    public Data zeroStep;
    Data activeStep;

    // Start is called before the first frame update
    void Start()
    {
        titleText.text = text;
        contentText.text = zeroStep.content;
        locationText.text = zeroStep.location;
        locationImage.sprite = zeroStep.background;
        activeStep = zeroStep;

        LoadButtonsText();

    }

    public void LoadButtonsText()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            if (activeStep.buttonText[i] == "null")
            {
                buttons[i].gameObject.SetActive(false);
            }
            else
            {
                Text buttonText = buttons[i].gameObject.GetComponentInChildren<Text>();
                buttonText.text = activeStep.buttonText[i];
            }
        }
    }

    public void OnAllButtons()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].gameObject.SetActive(true);
        }
    }

    public void ButtonClick(int index)
    {
        activeStep = activeStep.nextData[index];
        contentText.text = activeStep.content;
        locationText.text = activeStep.location;
        locationImage.sprite = activeStep.background;
        OnAllButtons();
        LoadButtonsText();
    }
}

