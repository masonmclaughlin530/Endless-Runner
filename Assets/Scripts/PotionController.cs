using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionController : MonoBehaviour
{
    private GameObject gameManager;
    private Camera mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            mainCamera.changeCameraSpeed(10);
            Destroy(this.gameObject);
        }

    }
}
