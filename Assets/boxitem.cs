using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxitem : MonoBehaviour {

    private Animator anim;
    public GameObject mushroom;
    public GameObject spawnPoint;

	// Use this for initialization
	void Start () {

        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnCollisionEnter2D(Collision2D collision)
    {
         anim.SetTrigger("playerhits");

        if (PlayerPlatformerController.playerState == 0)
        {
            Instantiate(mushroom, spawnPoint.transform.position, Quaternion.identity);
            //mushroomSpeed();
            //mushroom.GetComponent<Rigidbody2D>().velocity = new Vector2(4f, 0f);
            PlayerPlatformerController.playerState = 1;
        }
        
    }

    protected virtual void mushroomSpeed()
    {

    }
}
