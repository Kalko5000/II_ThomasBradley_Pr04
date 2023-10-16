using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereGroup01 : MonoBehaviour
{
    public detectCollision notificador;
    public cubeCollision notificador02;
    
    public Material newMat01;
    public Material newMat02;
    public GameObject cylinder;
    public float speed = 1.0f;
    public float jumpHeight = 5.0f;

    private Vector3 direction;
    private bool movement;
    
    // Start is called before the first frame update
    void Start()
    {
        notificador.cylinderCollision += cambioColor;
        notificador02.nearCylinder += cambioColorSalto;
        notificador02.collision += moveToCylinder;
    }

    // Update is called once per frame
    void Update()
    {
        if(movement) {
            direction = (cylinder.transform.position - transform.position).normalized;
            GetComponent<Rigidbody>().MovePosition(transform.position + (direction * speed * Time.deltaTime));
        }
    }
    
    void cambioColor() {
        GetComponent<MeshRenderer>().material = newMat02;
    }

    void cambioColorSalto() {
        GetComponent<MeshRenderer>().material = newMat01;
        GetComponent<Rigidbody>().AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
    }

    void moveToCylinder() {
        movement = true;
    }
}
