using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeCollision : MonoBehaviour
{
    public delegate void mensaje();
    public event mensaje group01Collision;
    public event mensaje collision;
    public event mensaje nearCylinder;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Sphere 01") {
            group01Collision();
        } else if (other.gameObject.tag != "Floor") {
            collision();
        }
    }

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Cylinder Radius") {
            nearCylinder();
        }
    }
}
