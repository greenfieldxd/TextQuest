using System.Collections;
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
    [TextArea(minLines:10, maxLines: 20)]public string content = "Перед вами два выхода: \n\n 1. Выход один \n 2. Выход два \n 3. Выйти";

    // Start is called before the first frame update
    void Start()
    {
        titleText.text = text;
        contentText.text = content;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
