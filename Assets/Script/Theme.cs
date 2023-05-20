using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Theme : MonoBehaviour
{

    private void Start()
    {
        FindObjectOfType<AudioManager>().Play("Theme");
        FindObjectOfType<AudioManager>().Play("Theme1");
        FindObjectOfType<AudioManager>().Play("Theme2");
    }
}
