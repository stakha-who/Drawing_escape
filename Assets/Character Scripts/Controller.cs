using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Rigidbody2D Rb;
    public float speed = 10f;
    public float jump = 1f;
    public float JumpTimer = 1;

    public GameObject Character;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
        if (Input.GetKey(KeyCode.A))
        {
            Rb.AddForce(Vector2.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Rb.AddForce(Vector2.right * speed * Time.deltaTime);
        }
        
    }
}
