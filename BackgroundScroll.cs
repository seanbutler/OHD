

//     INSERT VARIABLES 1 HERE

    public float speed = -1.0f;
    public float leftHandEdge = -10.0f;
    public float rightHandEdge = 10.0f;
    private float verticalOffset = 0;



    // INSERT SCROLL CODE HERE

        float realSpeed = speed * Time.deltaTime;
        transform.position += new Vector3(realSpeed, 0.0f, 0.0f);


        // INSERT RESET 1 CODE HERE

        if ( transform.position.x < leftHandEdge)
        {
            ResetPosition();
        }

    // INSERT RESET 2 CODE HERE

    void ResetPosition()
    {
        transform.position = new Vector3(rightHandEdge, verticalOffset, 0.0f);
    }

    // INSERT RESET 3 CODE HERE
    verticalOffset = transform.position.y;
