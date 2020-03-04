using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D physicsBody;
    public float upwardForce = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        physicsBody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (GameControl.instance.playerLives > 0)
        {
            if ( Input.GetMouseButtonDown(0) )
            {
                physicsBody.velocity = Vector2.zero;
                physicsBody.AddForce(Vector2.up * upwardForce);
            }
        }
    }
}
