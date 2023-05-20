using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleBreakDiss : MonoBehaviour
{
    private void Update()
    {
        Invoke("diss", 5f); 
    }

    public void diss()
    {
        Destroy(gameObject);
    }
}
