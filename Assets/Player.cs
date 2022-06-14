using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rigidbody2d;
    public float speed;
    public float acc = 1f;
    // Update is called once per frame
    void Update()
    {   
        if(Input.GetAxis("Horizontal")>0)
        {
            acc += 0.1f;
            rigidbody2d.velocity = new Vector2(speed*acc, 0f);
        }
        else if(Input.GetAxis("Horizontal")<0)
        {
            acc += 0.1f;
            rigidbody2d.velocity = new Vector2(-speed*acc, 0f);
        }
        else if(Input.GetAxis("Vertical")>0)
        {
           acc += 0.1f;
            rigidbody2d.velocity = new Vector2(0f, speed*acc);
        }
        else if(Input.GetAxis("Vertical")<0)
        {
            acc += 0.1f;
            rigidbody2d.velocity = new Vector2(0f, -speed*acc);
        }
        else if (Input.GetAxis("Vertical") == 0 && Input.GetAxis("Horizontal")==0 || Input.GetKey("Space"))
        {
            acc = 0;
            rigidbody2d.velocity = new Vector2(0f, 0f);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Door")
            Debug.Log("Level Complete!!!");
    }
    
}
