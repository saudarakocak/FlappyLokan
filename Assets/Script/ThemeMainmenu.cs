using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThemeMainmenu : MonoBehaviour
{
    private void Start()
    {
        FindObjectOfType<AudioManager>().Play("AcehSingkil");
    }
}
