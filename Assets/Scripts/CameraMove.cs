using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //moving Camera with Player
        transform.position = new Vector3(Player.position.x + 10.62655f, transform.position.y, transform.position.z);
    }
}
