using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;

    private float horizontalInput;

    public GameObject pizzaPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if(transform.position.x < -21)
        {
            transform.position = new Vector3(-21, transform.position.y, transform.position.z);
        }
        if(transform.position.x > 21)
        {
            transform.position = new Vector3(21, transform.position.y, transform.position.z);
        }

        // If space is clicked, spawn a pizza
        if(Input.GetKey(KeyCode.Space))
        {
            Instantiate(pizzaPrefab, transform.position + new Vector3(0,1.5f,0), pizzaPrefab.transform.rotation);
        }
        
    }
}
