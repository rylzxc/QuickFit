using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    public Text whiteText;
   
    public void ChangeTextColor()
    {
        whiteText.color = Color.black;
    }
}
