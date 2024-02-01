using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzeMovement : MonoBehaviour
{
    public float speed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        

        if(transform.position.z > 25)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
     // Check if the object we collided with has a tag called animal
        if (other.CompareTag("Animal")){  
            Destroy(other.gameObject);
            Destroy(gameObject);
            }
        
    }
}
