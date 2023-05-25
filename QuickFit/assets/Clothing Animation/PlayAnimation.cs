using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayAnimation : MonoBehaviour {
    private Animator anim;
    GameObject Shirt;
    GameObject Pant;
    bool ShirtWorn;
    bool PantWorn;


    void Start()
    {
        Pant = this.transform.GetChild(0).gameObject;
        Shirt = this.transform.GetChild(1).gameObject;
        anim = GetComponent<Animator>();
        ShirtWorn = false;
        PantWorn = false;
    }

    
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Shirt")) {
            ShirtWorn = true;
            Shirt.GetComponent<Renderer>().material = other.GetComponent<Renderer>().material;
            if (PantWorn) {
                anim.Play("ShirtAnimationWithPantWorn");
            } else {
                anim.Play("ShirtAnimation");
            }

        } else if(other.CompareTag("Pant")) {
            PantWorn = true;
            Pant.GetComponent<Renderer>().material = other.GetComponent<Renderer>().material;
            if (ShirtWorn) {
                anim.Play("PantAnimationWithShirtWorn");
            } else {
                anim.Play("PantAnimation");
            }

        }

    }
    
    private void OnTriggerExit(Collider other) {
        anim.Play("WearingBoth");
    }

    void Update()
    {
        Debug.Log("ShirtWorn: " + ShirtWorn);
        Debug.Log("PantWorn: " + PantWorn);
    }




}
