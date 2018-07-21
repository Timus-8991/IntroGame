using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom : MonoBehaviour {

   private Rigidbody2D rb2d;
	// Use this for initialization
	void Start () {
       rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector2(1f, 0f);
        
    }
	
	// Update is called once per frame
	
      private void OnCollisionEnter2D(Collision2D collision)
      {
        
            if (PlayerPlatformerController.playerState == 1)
                PlayerPlatformerController.playerState = 2;
            Destroy(this.gameObject);
        

      }
      


    /*protected override void mushroomSpeed()
    {
        rb2d.velocity = new Vector2(1f, 0f);
    }*/
}
