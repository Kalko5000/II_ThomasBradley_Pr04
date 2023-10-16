using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereGroup02 : MonoBehaviour
{
    public detectCollision notificador;
    public cubeCollision notificador02;
    
    public GameObject cylinder;
    public GameObject monument;
    public float speed = 1.0f;

    private bool movement;
    
    // Start is called before the first frame update
    void Start()
    {
        notificador.cylinderCollision += moveToCylinder;
        notificador02.nearCylinder += point;
        notificador02.group01Collision += grow;
    }

    // Update is called once per frame
    void Update()
    {
        if(movement && transform.position != cylinder.transform.position) {
            transform.LookAt(cylinder.transform);
            transform.Translate(transform.forward * speed * Time.deltaTime, Space.World);
        }
    }

    void moveToCylinder() {
        movement = true;
    }

    void point() {
        transform.LookAt(monument.transform);
    }

    void grow() {
        transform.localScale *= 1.05f;
    }
}
