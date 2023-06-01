using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColorButton : MonoBehaviour
{
    public GameObject button;
    public bool Toggle = true;

    public void ChangeButtonColor()
    {
        if (Toggle == true)
        {
            button.GetComponent<Image>().color = Color.black;
            Toggle = false;
        }
         else if (Toggle == false)
        {
            button.GetComponent<Image>().color = Color.white;
            Toggle = true;
        }   
    }
}
