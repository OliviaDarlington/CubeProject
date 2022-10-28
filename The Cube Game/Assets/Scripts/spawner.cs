using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// https://youtu.be/XO-E6QaTniQ this vid helped me 
//'Renaissance Coders' is the channel name
// I missed out on the instantiate bit in class. 

public class spawner : MonoBehaviour
{
    public Transform spawnPos;
    public GameObject spawnee;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Instantiate(spawnee, spawnPos.position, spawnPos.rotation);
        }
    }
}
