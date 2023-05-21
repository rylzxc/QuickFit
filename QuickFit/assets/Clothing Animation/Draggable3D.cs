using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable3D : MonoBehaviour
{
    Vector3 mousePosition;
    Vector3 initialPosition;

    void Start() {
        initialPosition = transform.position;
    }

    private Vector3 GetMousePos() {
        return Camera.main.WorldToScreenPoint(transform.position);
    }

    private void OnMouseDown() {
        Debug.Log("Down");
        mousePosition = Input.mousePosition - GetMousePos();   
    }

    private void OnMouseDrag() {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition - mousePosition);
    }

    
    private void OnMouseUp() {
        transform.position = initialPosition;
    }
    

    private void OnMouseEnter() {
        Debug.Log("enter");
    }

     
}
