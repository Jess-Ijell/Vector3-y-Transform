using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector3 movement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 6)
        {
            transform.position += movement;
        }

        //transform.localScale += movement;
        //transform.eulerAngles += movement;

    }
}
