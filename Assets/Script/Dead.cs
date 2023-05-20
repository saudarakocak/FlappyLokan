using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour
{
    public GameObject UI;

    private void Awake()
    {
        FindObjectOfType<AudioManager>().Play("Drown");
        FindObjectOfType<AudioManager>().Play("Croc");

    }

    public void dead()
    {
        UI.gameObject.SetActive(true);
    }
}
