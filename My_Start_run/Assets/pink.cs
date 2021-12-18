using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pink : MonoBehaviour
{
    [SerializeField] Animator froganim;
    [SerializeField] Animator maskanim;
    [SerializeField] Animator pinkanim;
    [SerializeField] Animator virtualanim;

    private void OnMouseDown()
    {
        froganim.SetBool("get", false);
        maskanim.SetBool("get", false);
        pinkanim.SetBool("get", true);
        virtualanim.SetBool("get", false);
    }
}
