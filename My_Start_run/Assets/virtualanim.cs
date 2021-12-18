using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class virtualanim : MonoBehaviour
{
    [SerializeField] Animator froganim;
    [SerializeField] Animator maskanim;
    [SerializeField] Animator pinkanim;
    [SerializeField] Animator virtualan;

    private void OnMouseDown()
    {
        froganim.SetBool("get", false);
        maskanim.SetBool("get", false);
        pinkanim.SetBool("get", false);
        virtualan.SetBool("get", true);
    }
}
