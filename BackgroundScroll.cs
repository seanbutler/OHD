using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    public float speed = -1.0f;
    public float leftHandEdge = -10.0f;
    public float rightHandEdge = 10.0f;

    private float verticalOffset = 0;
    // Start is called before the first frame update
    void Start()
    {
        verticalOffset = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        float realSpeed = speed * Time.deltaTime;
        transform.position += new Vector3(realSpeed, 0.0f, 0.0f);

        if ( transform.position.x < leftHandEdge)
        {
            ResetPosition();
        }
    }

    void ResetPosition()
    {
        transform.position = new Vector3(rightHandEdge, verticalOffset, 0.0f);
    }

}
