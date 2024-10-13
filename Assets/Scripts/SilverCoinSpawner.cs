using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SilverCoinSpawner : MonoBehaviour
{
    public GameObject coin;
    public float maxX;
    public float maxY;
    public float minX;
    public float minY;
    private float time;
    public float delay;
    private float randomX;
    private float randomY;

    // Start is called before the first frame update
    void Start()
    {
        setTimer();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time >= delay)
        {
            spawn();

            time = 0f;
            setTimer();
        }
    }

    private void spawn()
    {
        randomX = Random.Range(minX, maxX);
        randomY = Random.Range(minY, maxY);

        Instantiate(coin, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }

    private void setTimer()
    {
        delay = Random.Range(5, 10);
    }
}
