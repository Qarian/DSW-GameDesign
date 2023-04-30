using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncy : MonoBehaviour
{
    public Vector3 speed;
    public int counter = 0;

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 position = GetComponent<Transform>().position;
        Vector3 targetPosition = position + (speed * Time.fixedDeltaTime);

        GetComponent<Rigidbody>().MovePosition(targetPosition);
    }

    private void OnCollisionEnter(Collision collision)
    {
        speed *= -1;
    }

    private void OnTriggerEnter(Collider other)
    {
        counter++;
    }
}
