using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubePointsCollision : MonoBehaviour
{
    public delegate void mensaje();
    public event mensaje fivePoints;
    public event mensaje tenPoints;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Points01") {
            fivePoints();
            Destroy(other.gameObject);
        } else if (other.gameObject.tag == "Points02") {
            tenPoints();
            Destroy(other.gameObject);
        }
    }
}
