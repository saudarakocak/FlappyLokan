using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public GameObject Effect;

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Instantiate(Effect, this.transform.position, Quaternion.identity);
            FindObjectOfType<AudioManager>().Play("RedFlyAttack");
            Destroy(gameObject);
        }
    }
}
