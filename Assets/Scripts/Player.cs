using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float playerSpeed;
    private Rigidbody2D surfer;
    private Vector2 playerDirection;
    private GameManager gameManager;
    private GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        surfer = GetComponent<Rigidbody2D>();
        //player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        playerDirection = new Vector2(0, directionY).normalized;
    }

    void FixedUpdate()
    {
        surfer.velocity = new Vector2(0, playerDirection.y * playerSpeed);    
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Bird"))
        {
            //Destroy(surfer);
            Destroy(this.gameObject);
            
        }

        if (collision.gameObject.CompareTag("Shark"))
        {
            //Destroy(surfer);
            Destroy(this.gameObject);

        }

        if (collision.gameObject.CompareTag("Bouy"))
        {
            //Destroy(surfer);
            Destroy(this.gameObject);

        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Coin"))
        {
            //
        }
    }

}
