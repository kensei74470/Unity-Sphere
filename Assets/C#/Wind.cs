using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour {

    public float Player_Jump;
    public bool Jump;
    GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        player = GameObject.Find("Player");
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (Jump)
            {
                player.GetComponent<Rigidbody2D>().AddForce(transform.up * Player_Jump * Time.deltaTime, ForceMode2D.Impulse);
            }
        }
    }
}
