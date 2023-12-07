using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] public float speed = 1f;
    [SerializeField] private Rigidbody rb;

    // Update is called once per frame
    void Update()
    {
        var direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        rb.velocity = direction * speed;

        /*
        // Descend using LeftShift
        if (Input.GetKey(KeyCode.LeftShift))
        {
            var descend = new Vector3(0, -1, 0);
            rb.velocity += descend;
        }

        // Ascend using Space
        if (Input.GetKey(KeyCode.Space))
        {
            var ascend = new Vector3(0, 1, 0);
            rb.velocity += ascend;
        }
        */
    }
}
