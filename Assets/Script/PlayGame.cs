using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayGame : MonoBehaviour
{
    public static bool Play;

    private void Start()
    {
        Play = false;
    }
    public void play()
    {
        Play = true;
    }
}
