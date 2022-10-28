using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// https://youtu.be/XO-E6QaTniQ this vid helped me 
//'Renaissance Coders' is the channel name
// I missed out on the instantiate bit in class. 

public class Destroy : MonoBehaviour
{
public float lifeTime = 10f;

    // Update is called once per frame
    void Update()
    {
        if(lifeTime > 0)
        {
            lifeTime -= Time.deltaTime;
        }
    if(lifeTime <= 0)
    {
      Destruction();
    }

     if(this.transform.position.y <= -20)
     {
        Destruction();
     }

     void OnCollisionEnter(Collision coll)
     {
        if(coll.gameObject.name == "destroyer")
        {
            Destruction();
        }
     }

     void Destruction()
     {
        Destroy(this.gameObject);
     }
}
}
