using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerPlatformer : MonoBehaviour
{
    public float speed = 1f;
    public float jumpForce = 5f;
    Rigidbody2D rb;
    SpriteRenderer sr;

    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        float movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * speed * Time.deltaTime;

        anim.SetFloat("moveX", Mathf.Abs(Input.GetAxisRaw("Horizontal")));

        if (Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(rb.velocity.y) < 0.05f)
        {
            rb.AddForce(new Vector2 (0, jumpForce), ForceMode2D.Impulse);
            anim.SetBool("Jumping", true);
        }
        else
        {
           
            anim.SetBool("Jumping", false);
        }

        sr.flipX = movement < 0 ? true : false;

    }

}
