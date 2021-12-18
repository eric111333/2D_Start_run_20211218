using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maskanim : MonoBehaviour
{
    [SerializeField] Animator froganim;
    [SerializeField] Animator maskanim;
    [SerializeField] Animator pinkanim;
    [SerializeField] Animator virtualanim;

    private void OnMouseDown()
    {
        froganim.SetBool("get", false);
        maskanim.SetBool("get", true);
        pinkanim.SetBool("get", false);
        virtualanim.SetBool("get", false);
    }
}
