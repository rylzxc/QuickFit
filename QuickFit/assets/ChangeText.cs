using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class ChangeText : MonoBehaviour
{
    public GameObject whiteText;
    public void ChangeTextName()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        TextAsset txtAsset = (TextAsset)Resources.Load(buttonName);

        whiteText.GetComponent<TMP_Text>().text = buttonName;
    }
}
