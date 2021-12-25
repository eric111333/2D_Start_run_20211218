using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    Rigidbody2D Rigidbody1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Rigidbody1 = collision.GetComponent<Rigidbody2D>();
        Rigidbody1.AddForce(new Vector2(Rigidbody1.velocity.x, 10f), ForceMode2D.Impulse);

    }
}
