using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Cube : MonoBehaviour
{
    Rigidbody rb;
    float movementSpeed = 5f;
    public ParticleSystem ParticleSystem;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        //rb.velocity = transform.forward *  movementSpeed;
        rb.AddForce(transform.forward * movementSpeed, ForceMode.Force);
    }

    private void OnCollisionEnter(Collision cubeTrigger)
    {
        if (cubeTrigger.gameObject.tag == "TriggerCube")
        {
            print("collided");

        }
    }

    public void OnTriggerEnter(Collider cubeTrigger)
    {
        if (cubeTrigger.gameObject.tag == "TriggerCube")
        {
            Instantiate(ParticleSystem, cubeTrigger.transform.position,Quaternion.identity);

        }
    }



}



