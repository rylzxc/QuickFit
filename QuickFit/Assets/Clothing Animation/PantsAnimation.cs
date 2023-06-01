using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PantsAnimation : MonoBehaviour {

    GameObject parent;


    void Start()
    {
        parent = this.transform.parent.gameObject;
    }

    
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Pant")) {
            this.GetComponent<Renderer>().material = other.GetComponent<Renderer>().material;
            parent.GetComponent<PlayAnimation>().PantWorn = true;
            if (parent.GetComponent<PlayAnimation>().ShirtWorn) {
                parent.GetComponent<Animator>().Play("PantAnimationWithShirtWorn");
            } else {
                parent.GetComponent<Animator>().Play("PantAnimation");
            }
        }
    }

    private void OnTriggerExit(Collider other) {
        parent.GetComponent<Animator>().Play("WearingBoth");

    }
    



}
