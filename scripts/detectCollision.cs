using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectCollision : MonoBehaviour
{
    public delegate void mensaje();
    public event mensaje cylinderCollision;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Detect collisions between the GameObjects with Colliders attached
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided with " + other.gameObject.tag);
        if(other.gameObject.tag == "Cube") {
            cylinderCollision();
        }
    }
}
