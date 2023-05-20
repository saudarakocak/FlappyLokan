using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleMovement : MonoBehaviour
{
    public float speed;
    private Point playerPoint;



    // Update is called once per frame
    void Update()
    {
        if (PlayGame.Play)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);

            playerPoint = GameObject.FindGameObjectWithTag("Player").GetComponent<Point>();



            if (playerPoint.point < 20 && playerPoint.point > 10)
            {
                speed = 6;
            }
            else if (playerPoint.point < 30 && playerPoint.point > 20)
            {
                speed = 10;
            }
            else if (playerPoint.point > 50)
            {
                speed = 25;
            }
        }
    }
    
}
