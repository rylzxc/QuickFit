using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayAnimation : MonoBehaviour {
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Shirt")) {
            Debug.Log("TRIGGERED!!!");
            anim.Play("ShirtAnimation");
        }
    }
    

    
    private void OnMouseUp() {
        Debug.Log("TRIGGERED!!!");
        anim.Play("ShirtAnimation");
    }
    


    /*
    private void OnMouseEnter() {
        if trigg
    }

    */

    private void OnTriggerExit(Collider other) {
        if (other.CompareTag("Shirt")) {
            anim.Play("Wearing");
        }
    }




}
