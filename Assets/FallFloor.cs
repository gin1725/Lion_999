using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallFloor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Player")){
            Destroy(gameObject);
            //Invoke("Fall",0.1f);
        }
    }

    void Fall(){
        GetComponent<Rigidbody>().isKinematic = false;
    }
}

