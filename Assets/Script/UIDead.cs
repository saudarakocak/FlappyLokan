using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIDead : MonoBehaviour
{
    private void Awake()
    {
        FindObjectOfType<AudioManager>().Play("UIDead");
    }
}
