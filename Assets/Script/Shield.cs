using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public GameObject player;
    public GameObject obstacleBreak;


    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = player.transform.position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "obstacle")
        {
            FindObjectOfType<AudioManager>().Play("Rock");
            Debug.Log(collision.transform.position);
            Instantiate(obstacleBreak, collision.transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
        }
    }
}
