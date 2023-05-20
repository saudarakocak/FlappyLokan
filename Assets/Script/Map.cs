using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayGame.Play)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
    }

}
