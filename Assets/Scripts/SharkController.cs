using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkController : MonoBehaviour
{
    private GameObject player;
    private Vector2 playerLocation;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        { 
        playerLocation = player.transform.position;
        transform.position = Vector2.MoveTowards(transform.position, playerLocation, speed);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Border"))
        {
            Destroy(this.gameObject);
        }
    }
}
