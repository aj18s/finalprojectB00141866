using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerItemCollect : MonoBehaviour
{
    public GameObject PlayerShield;
    public GameObject PlayerFire;
    public static bool haveShield;
    public static bool haveSpeed;

    public float TimeForShoes;
    public Text timeForShoes;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Showing the time left of spped increase PowerUp on screen 
        timeForShoes.text = "SpeedUp Time left = " + (int)TimeForShoes + " Seconds";
        
        //Showing Shield particle Effect Arround Player
        if(haveShield == true)
        {
            PlayerShield.SetActive(true);
        }else{
            PlayerShield.SetActive(false);
        }

// Decrease time of the Speed as the time Passes and also Showing the fire effect around player when speed is increased
        if(haveSpeed == true)
        {
            TimeForShoes = TimeForShoes - Time.deltaTime;
            gameObject.GetComponent<SimpleSampleCharacterControl>().m_moveSpeed = 15;
            timeForShoes.text = "SpeedUp Time left = " + (int)TimeForShoes + " Seconds";
            PlayerFire.SetActive(true);
        }
        if(TimeForShoes <= 0)
        {
            haveSpeed = false;
            gameObject.GetComponent<SimpleSampleCharacterControl>().m_moveSpeed = 10;
            timeForShoes.text = "";
            PlayerFire.SetActive(false);
        }
        
    }
    
    //Checking if Collected Shield Or SpeedUp
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Shield")
        {
            haveShield = true;
            Destroy(other.gameObject);
        }
        if(other.tag == "Speed")
        {
            TimeForShoes = 6f;
            haveSpeed = true;
            Destroy(other.gameObject);
        }
    }
}
