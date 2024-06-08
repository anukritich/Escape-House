using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dooranim : MonoBehaviour
{
    public Animator anim;
    public KeyPad pass;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        Animationplay();
    }
    public void Animationplay()
    {
        if (pass.passcheck == true)
        {
            Debug.Log("Door open");
            anim.SetTrigger("doorOpen");
        }
    }
}

    
