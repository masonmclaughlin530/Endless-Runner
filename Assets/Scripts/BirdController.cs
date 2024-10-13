using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float birdSpeed;
    private Rigidbody bird;
    private float startY;
    private bool moveDown;
    private float y;


    // Start is called before the first frame update
    void Start()
    {
        moveDown = true;
        startY = transform.position.y;
        y = startY - 1;
    }

    // Update is called once per frame
    void Update()
    {
        moveBird();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Border"))
        {
            Destroy(this.gameObject);
        }
    }

    private void moveBird()
    {
        if (transform.position.y <= y)
        {
            transform.Translate(Vector2.up * birdSpeed * Time.deltaTime);
        }
        else if (transform.position.y >= startY)
        {
            transform.Translate(Vector2.down * birdSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.down * birdSpeed * Time.deltaTime);
        }
        if (transform.position.y >= startY)
        {
            moveDown = false;
        }
        else
        {
            moveDown = true;
        }
    }

}
