using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject obstacle;
    float time = 2;
    float posisiY, temp;



    private void Update()
    {
        if (PlayGame.Play)
        {
            posisiY = Random.Range(2.77f, 8.4f);
            temp = Random.Range(2, 5);

            time -= Time.deltaTime;

            Vector2 posisi = new Vector2(transform.position.x, posisiY);

            if (time < 0)
            {
                Instantiate(obstacle, posisi, Quaternion.identity);
                time = temp;
            }
        }
    }

}
