using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerEnemy : MonoBehaviour
{
    public GameObject redfly;
    public float time;
    float temp, posisiY;



    private void Update()
    {
        if (PlayGame.Play)
        {
            temp = Random.Range(3, 20);
            time -= Time.deltaTime;
            posisiY = Random.Range(-4.27f, 1.4f);

            Vector2 posisi = new Vector2(transform.position.x, posisiY);

            if (time < 0)
            {
                Instantiate(redfly, posisi, Quaternion.identity);
                time = temp;
            }
        }
    }
}
