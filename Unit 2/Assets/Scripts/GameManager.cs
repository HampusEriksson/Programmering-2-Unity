using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject[] animalPrefabs;
    private float spawnInterval = 0.5f;
    private float startDelay = 2.0f;
    


    void Start()
    {
        InvokeRepeating("spawnAnimal", startDelay, spawnInterval);
        
    }

    // Update is called once per frame
    void Update()
    {
        

        
    }


    private void spawnAnimal(){
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], new Vector3(Random.Range(-20,20), 0.2f, 25), animalPrefabs[animalIndex].transform.rotation);
    }
}
