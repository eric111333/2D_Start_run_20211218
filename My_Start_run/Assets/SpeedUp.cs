using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{


    Rigidbody2D Rigidbody2;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Rigidbody2 = collision.GetComponent<Rigidbody2D>();
        Rigidbody2.velocity = Vector3.right * 1f;
        Rigidbody2.AddForce(Rigidbody2.velocity * 1.2f, ForceMode2D.Impulse);
        //collision.attachedRigidbody.AddForce(new Vector2(10f,10));
    }
}

