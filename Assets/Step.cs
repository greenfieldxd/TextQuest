using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Step : MonoBehaviour
{

    [TextArea(minLines: 10, maxLines: 40)]
    public string content = "Content Text";
    public string location = "Location Text";


    public Step[] nextSteps;

}
