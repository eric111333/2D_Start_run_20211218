using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayGo : MonoBehaviour
{
    [SerializeField] Rigidbody2D rig;
    void Start()
    {
        //rig.velocity = Vector3.right * 5f;
    }

    // Update is called once per frame
    void Update()
    {
        //rig.velocity = Vector3.right * 5f;
        //rig.AddForce(new Vector2 (1f,0f));
        //transform.Translate(Vector3.right * 5f * Time.deltaTime, Space.World);
        rig.AddForce(new Vector2(0.1f,0f), ForceMode2D.Impulse);
    }
}
