using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data Asset")] // любое имя для пункта меню
public class Data : ScriptableObject
{
    [TextArea(minLines: 10, maxLines: 40)]
    public string content = "Content Text";
    public string location = "Location Text";
    public Sprite background;

    public Data[] nextData;


}
