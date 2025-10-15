using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamething : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public class controls : MonoBehaviour {

public float movespeed;
public float jumphight;
public float ;
public float ;
public Transform Gcheck;
public float GcheckRadius;
public bool onground;

KeyCode w;
KeyCode a;
KeyCode d;

    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKey(d)){
        GetComponent<Rigidbody2D>().velocity = new vector (movespeed, GetComponent<Rigidbody2D>().velocity.y);
      GetComponent<SpriteRenderer>(.flipX = false);
       }
       if (Input.GetKey(a)){
        GetComponent<Rigidbody2D>().velocity = new vector (-movespeed, GetComponent<Rigidbody2D>().velocity.y);
      GetComponent<SpriteRenderer>(.flipX = true);
      }
        if (Input.GetKeyDown(w)) jump();
    }

    void jump() {
       GetComponent<Rigidbody2D>().velocity = new vector (movespeed, GetComponent<Rigidbody2D>().velocity.x);
    }
    void FixedUpdate()
    {
        ongroundS
    }

}
