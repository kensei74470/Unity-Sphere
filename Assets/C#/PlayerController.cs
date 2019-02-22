using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    float walkForce = 40.0f;
    float maxWalkSpeed = 2.5f;
    // Use this for initialization
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 2;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -2;
        if (Input.GetKey(KeyCode.D)) key = 2;
        if (Input.GetKey(KeyCode.A)) key = -2;

        float speedx = Mathf.Abs(this.rigid2D.velocity.x);

        if (speedx < this.maxWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }
        if (transform.position.y < -7)
        {
            SceneManager.LoadScene("Clear");
        }
    }
}
    

