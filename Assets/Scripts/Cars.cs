using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cars : MonoBehaviour
{
    public GameObject Explosion;
    public AudioClip ExplosionClip;
    AudioSource player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Cars Moving forward On road
        transform.Translate(0,0,0.3f);

        //Destroying Cars When out of screen
        if(transform.position.z >= 54.229705810546878f)
        Destroy(this.gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        //Destroying Car and player when Collided with Player
        if(other.tag == "Player")
        {
            Instantiate(Explosion, transform.position, Quaternion.identity);
            GameObject.Find("Button Controller").GetComponent<AudioSource>().PlayOneShot(ExplosionClip);
            if(PlayerItemCollect.haveShield == false)
            {
            other.gameObject.SetActive(false);
            GameObject.Find("Button Controller").GetComponent<Controller>().OverPanel();
            }else{
                // if player have shield destroying shield instead of Player
                PlayerItemCollect.haveShield = false;
            }
            Destroy(this.gameObject);
        }
    }
}
