using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapSpawn : MonoBehaviour
{
    public GameObject map;
    public float time;
    public float timeTemp;
    Vector2 p = new Vector2(22.73f, -0.2579158f);
    private void Start()
    {
        Instantiate(map, new Vector2(-0.01f, transform.position.y), Quaternion.identity);

    }
    void Update()
    {
        if (PlayGame.Play)
        {
            timeTemp -= Time.deltaTime;
            if (timeTemp < 0)
            {
                spawn();
                timeTemp = time;
            }
        }
    }

    void spawn()
    {
        Instantiate(map, p, Quaternion.identity);
    }
}
