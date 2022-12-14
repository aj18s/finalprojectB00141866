using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackSpawner : MonoBehaviour
{
    public GameObject Track;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Whenever player Corrses the roaded Spawning new road Ahead
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Instantiate(Track, new Vector3(transform.position.x - 66f, transform.position.y, transform.position.z), Quaternion.identity);
            GameObject.Find("Button Controller").GetComponent<Controller>().Score += 1;
            Destroy(this.gameObject);           
        }
    }
}
