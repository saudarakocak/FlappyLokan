using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerMovement : MonoBehaviour
{
    public float speed;

    void Update()
    {
        if (PlayGame.Play)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
