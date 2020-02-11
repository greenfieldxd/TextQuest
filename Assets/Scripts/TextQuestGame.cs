using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextQuestGame : MonoBehaviour
{
    [Header("Elements")]
    public Text titleText;
    public Text contentText;
    public Text locationText;
    public Image locationImage;
    

    [Header("Config")]
    public string text = "Четвертая планета";
    public int titleTextSize = 30;
    
    public Step zeroStep;
    Step activeStep;

    // Start is called before the first frame update
    void Start()
    {
        titleText.text = text;
        contentText.text = zeroStep.content;
        locationText.text = zeroStep.location;
        locationImage.sprite = zeroStep.background;
        activeStep = zeroStep;

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

        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            CheckPress(3);
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            contentText.text = zeroStep.content;
            locationText.text = zeroStep.location;
            locationImage.sprite = zeroStep.background;
            activeStep = zeroStep;
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
                locationText.text = activeStep.location;
                locationImage.sprite = activeStep.background;
            }
        }
    }

}
