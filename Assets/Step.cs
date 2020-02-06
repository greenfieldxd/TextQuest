using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Step : MonoBehaviour
{

    [TextArea(minLines: 10, maxLines: 20)]
    public string content = "Content Text";

    public Step[] nextSteps;

}
