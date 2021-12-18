using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frog : MonoBehaviour
{
    [SerializeField] Animator froganim;
    [SerializeField] Animator maskanim;
    [SerializeField] Animator pinkanim;
    [SerializeField] Animator virtualanim;

    private void OnMouseDown()
    {
        froganim.SetBool("get",true);
        maskanim.SetBool("get", false);
        pinkanim.SetBool("get", false);
        virtualanim.SetBool("get", false);
    }
    private void OnTriggerEnter(Collider other)
    {
        
    }
}
