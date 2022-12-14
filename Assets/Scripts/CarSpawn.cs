using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawn : MonoBehaviour
{
    public GameObject[] cars; 
    // Start is called before the first frame update
    void Start()
    {
       Invoke("Spawn", 1f);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // Randomly Spawning Cars after 1 second on the road
    void Spawn()
    {
        int CarNumber = Random.Range(0, cars.Length);
        Instantiate(cars[CarNumber], transform.position, Quaternion.identity);
       float timeBetweenSpawn = Random.Range(0.6f, 1.3f);
       Invoke("Spawn", timeBetweenSpawn);
    }
}
