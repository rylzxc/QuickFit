using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShirtAnimation : MonoBehaviour {
    GameObject parent;

    void Start()
    {
        parent = this.transform.parent.gameObject;
    }

    
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Shirt")) {
            this.GetComponent<Renderer>().material = other.GetComponent<Renderer>().material;
            parent.GetComponent<PlayAnimation>().ShirtWorn = true;
            if (parent.GetComponent<PlayAnimation>().PantWorn) {
                parent.GetComponent<Animator>().Play("ShirtAnimationWithPantWorn");
            } else {
                parent.GetComponent<Animator>().Play("ShirtAnimation");
            }
        }
    }

    private void OnTriggerExit(Collider other) {
        parent.GetComponent<Animator>().Play("WearingBoth");

    }
    



}
