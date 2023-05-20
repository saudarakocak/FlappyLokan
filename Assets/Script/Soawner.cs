using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soawner : MonoBehaviour
{
    public GameObject obstacle;
    public float time = 5;
    float temp;



    private void Update()
    {
        if (PlayGame.Play)
        {
            temp = Random.Range(5, 15);

            time -= Time.deltaTime;

            Vector2 posisi = new Vector2(transform.position.x, transform.position.y);

            if (time < 0)
            {
                Instantiate(obstacle, posisi, Quaternion.identity);
                time = temp;
            }
        }
    }
}
