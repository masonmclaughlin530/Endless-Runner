using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Airhorn : MonoBehaviour
{
    public GameObject bird;
    public GameObject shark;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            if (GameObject.FindGameObjectWithTag("Bird") != null)
            {
                //DestroyImmediate(GameObject.FindGameObjectWithTag("Bird"));
                //Destroy(bird);
                //bird.transform.Translate(Vector2.up * 5 * Time.deltaTime);
                GameObject.FindGameObjectWithTag("Bird").transform.Translate(Vector2.up * 2);
            }

            if (GameObject.FindGameObjectWithTag("Shark") != null)
            {
                //DestroyImmediate(shark, true);
                //Destroy(shark);
                GameObject.FindGameObjectWithTag("Shark").transform.Translate(Vector2.down * 2);
            }

            Destroy(this.gameObject);
        }

        
    }
}
