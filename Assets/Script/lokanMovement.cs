using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lokanMovement : MonoBehaviour
{
    public Rigidbody2D body;
    public float jump;
    public float speed;
    public Point gameOver;
    public Animator animasi;
    public ParticleSystem jumpvfx;
    bool touchedLastFrame = false;


    public void down()
    {
        animasi.SetBool("jump", false);
    }


    private void Update()
    {
        if (PlayGame.Play)
        {
            if (touchedLastFrame && Input.touchCount == 0)
            {
                touchedLastFrame = false;
            }
            else if (!touchedLastFrame && Input.touchCount > 0)
            {


                //animasiLompat
                animasi.SetBool("jump", true);
                jumpvfx.gameObject.SetActive(true);
                jumpvfx.Play();

                //lompat
                if (!gameOver.gamestop)
                {
                    //sound
                    FindObjectOfType<AudioManager>().Play("Jump");

                    if (transform.position.x < -1.99)
                    {
                        body.AddForce(new Vector2(body.velocity.x, jump));
                        body.AddForce(new Vector2(speed, body.velocity.y));
                        Debug.Log("loncat");
                    }
                    else if (transform.position.x > 3)
                    {
                        body.AddForce(new Vector2(speed * -1, body.velocity.y));
                        body.AddForce(new Vector2(body.velocity.x, jump));
                        Debug.Log("loncat");
                    }
                    else
                    {
                        body.AddForce(new Vector2(body.velocity.x, jump));
                        Debug.Log("loncat");
                    }
                }



                touchedLastFrame = true;
            }



        }
    }
}
