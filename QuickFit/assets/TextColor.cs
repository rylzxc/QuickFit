using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextColor : MonoBehaviour
{
    public GameObject whiteText;
    public bool Toggle = true;

    public void ChangeTextColor()
    {
        if (Toggle == true)
        {
            whiteText.GetComponent<TMP_Text>().color = Color.white;
            Toggle = false;
        }
        else if (Toggle == false)
        {
            whiteText.GetComponent<TMP_Text>().color = Color.black;
            Toggle = true;
        }
    }
}

