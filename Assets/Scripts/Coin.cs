using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinVal;
    private Score score;
    private GameObject gameManager;
    
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
        score = gameManager.GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            score.addToScore(coinVal);
            Destroy(this.gameObject);
        }
        if (collision.gameObject.CompareTag("Border"))
        {
            Destroy(this.gameObject);
        }
    }
}
