using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleText : MonoBehaviour
{
    public GameObject sizeToggle;
    public GameObject background;
    public bool isActive;
    public Text label;
    public void ChangeTextColor()
    {
        isActive = sizeToggle.GetComponent<Toggle>().isOn;

        if (isActive == true)
        {
            background.GetComponent<Image>().color = Color.black;
            label.GetComponent<Text>().color = Color.white;
        }
        else if (isActive == false)
        {
            background.GetComponent<Image>().color = Color.white;
            label.GetComponent<Text>().color = Color.black;
        }
    }
}
