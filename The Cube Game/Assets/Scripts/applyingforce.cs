using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class applyingforce : MonoBehaviour
{
    Rigidbody ourRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        ourRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            ourRigidBody.AddExplosionForce(500, transform.position + Vector3.down, 2);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            ourRigidBody.AddForce(Vector3.left);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            ourRigidBody.AddForce(Vector3.right);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        collision.transform.position += Vector3.down;
       
    }
}
