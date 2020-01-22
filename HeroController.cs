using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour
{
    Animator anim;

    Rigidbody2D body;
    public float  jumpForce;
    private bool isGrounded;

    void Start()
    {
        anim = GetComponent<Animator>();
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && isGrounded)
        {
            anim.SetTrigger("Jump");
            body.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

   void OnTriggerEnter2D(Collider2D other )
    {
        if (other.tag == "ground")
        {
            isGrounded = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "ground")
        {
            isGrounded = false;
        }
    }
}
