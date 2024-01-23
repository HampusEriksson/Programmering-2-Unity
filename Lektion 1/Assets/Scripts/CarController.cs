using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    // private/public datatyp variabelnamn = värde;
    private float max_speed = 20.0f;
    private float min_speed = 0.0f;
    private float speed = 0.0f;
    private float turnSpeed = 50.0f;


    private float forwardInput;
    private float turnInput;
    private float jumpInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        turnInput = Input.GetAxis("Horizontal");
        jumpInput = Input.GetAxis("Jump");


        if(forwardInput > 0){
            speed += 4.0f * Time.deltaTime;
        }
        else{
            speed -= 4.0f * Time.deltaTime;
        }
        if(speed > max_speed){
            speed = max_speed;
        }
        if(speed < min_speed){
            speed = min_speed;
        }
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnInput * turnSpeed);
        
        // Jump by doing an impulse force
        if (jumpInput > 0)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 100, ForceMode.Impulse);
        }
    }
}
