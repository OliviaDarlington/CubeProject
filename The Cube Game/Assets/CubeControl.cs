using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl : MonoBehaviour
{
    private float turningSpeed=180;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        transform.position += Vector3.up* Time.deltaTime;

        if (Input.GetKey(KeyCode.DownArrow))
            transform.position -= Vector3.up * Time.deltaTime;

        if(Input.GetKey(KeyCode.W))
  transform.position += transform.forward  * Time.deltaTime;

        if (Input.GetKey(KeyCode.D))
        transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.A))
        transform.Rotate(Vector3.down, turningSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.S))
        transform.position -= transform.forward * Time.deltaTime;
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(cubeTemplate,
                transform.position - transform.forward,
                Quaternion.identity);
        }

    
    }
}
