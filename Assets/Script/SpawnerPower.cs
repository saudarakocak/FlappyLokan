using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerPower : MonoBehaviour
{
    public GameObject power, power1, power2, power3, power4, power5;
    float divide;
    public float time = 5;
    float temp, posisiY;
    


    private void Update()
    {
        if (PlayGame.Play)
        {
            temp = Random.Range(10, 20);
            divide = Random.Range(0, 6);
            time -= Time.deltaTime;
            posisiY = Random.Range(-2.29f, 4.46f);

            Vector2 posisi = new Vector2(transform.position.x, posisiY);

            if (time < 0)
            {
                if (divide < 1)
                {
                    Instantiate(power, posisi, Quaternion.identity);
                    time = temp;
                }
                else if (divide >= 1 && divide < 2)
                {
                    Instantiate(power1, posisi, Quaternion.identity);
                    time = temp;
                }
                else if (divide >= 2 && divide < 3)
                {
                    Instantiate(power2, posisi, Quaternion.identity);
                    time = temp;
                }
                else if (divide >= 3 && divide < 4)
                {
                    Instantiate(power3, posisi, Quaternion.identity);
                    time = temp;
                }
                else if (divide >= 4 && divide < 5)
                {
                    Instantiate(power4, posisi, Quaternion.identity);
                    time = temp;
                }
                else if (divide >= 5 && divide <= 6)
                {
                    Instantiate(power5, posisi, Quaternion.identity);
                    time = temp;
                }
            }
        }
    }
}
