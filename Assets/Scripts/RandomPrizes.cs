using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPrizes : MonoBehaviour
{
    public GameObject[] items;
    // Start is called before the first frame update
    void Start()
    {
        // Chose Random number between 1 and 4
        int PrizeOrNot = Random.Range(1, 4);
        //if 4 came the powerUp will show
        if(PrizeOrNot == 3)
        {
            //if power up is showing deciding which powerup Speed or Shield
            int ItemNumber = Random.Range(0, items.Length);
            Instantiate(items[ItemNumber], transform.position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
