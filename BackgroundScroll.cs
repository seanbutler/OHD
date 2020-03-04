using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{

//     INSERT VARIABLES 1 HERE

    public float speed = -1.0f;
    public float leftHandEdge = -10.0f;
    public float rightHandEdge = 10.0f;

    private float verticalOffset = 0;
    // Start is called before the first frame update
    void Start()
    {
        // INSERT RESET 3 CODE HERE
        verticalOffset = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {

// INSERT SCROLL CODE HERE

        float realSpeed = speed * Time.deltaTime;
        transform.position += new Vector3(realSpeed, 0.0f, 0.0f);


        // INSERT RESET 1 CODE HERE

        if ( transform.position.x < leftHandEdge)
        {
            ResetPosition();
        }
    }


    // INSERT RESET 2 CODE HERE

    void ResetPosition()
    {

        // INSERT RESET 2 CODE HERE

        transform.position = new Vector3(rightHandEdge, verticalOffset, 0.0f);
    }

}
