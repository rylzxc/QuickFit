using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayAnimation : MonoBehaviour {
    
    private Animator anim;
    GameObject Shirt;
    GameObject Pant;
    public bool ShirtWorn;
    public bool PantWorn;

    void Start()
    {
        anim = GetComponent<Animator>();
        ShirtWorn = false;
        PantWorn = false;

    }


}
