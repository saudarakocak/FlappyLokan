using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerEffect : MonoBehaviour
{

    public Animator animasiEffect;
    public int random;
    public Rigidbody2D Mc;
    public GameObject shieldObj;

    private void Update()
    {
        random = Random.Range(1, 5);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bigger")
        {
            Big();
        }
        else if (collision.gameObject.tag == "smaller")
        {
            Small();   
        }
        else if (collision.gameObject.tag == "timeSlow")
        {
            slow();
        }
        else if (collision.gameObject.tag == "timeFast")
        {
            fast();   
        }
        else if (collision.gameObject.tag == "shieldItem")
        {
            shield();
        }
        else if (collision.gameObject.tag == "Random")
        {
            switch (random)
            {
                case 1: Big();
                    break;
                case 2: Small();
                    break;
                case 3: slow();
                    break;
                case 4: fast();
                    break;
                case 5: shield();
                    break;
            }
        }
    }

    public void Big()
    {
        animasiEffect.SetBool("bigger", true);
        FindObjectOfType<AudioManager>().Play("PowerUp");
    }
    public void Small()
    {
        FindObjectOfType<AudioManager>().Play("PowerUp");
        animasiEffect.SetBool("smaller", true);
    }
    public void slow()
    {
        FindObjectOfType<AudioManager>().Play("PowerUp");
        animasiEffect.SetBool("timeSlow", true);
        Time.timeScale = 0.5f;
    }
    public void fast()
    {
        FindObjectOfType<AudioManager>().Play("PowerUp");
        animasiEffect.SetBool("timeFast", true);
        Time.timeScale = 2f;
        Mc.gravityScale = 1f;
    }
    public void shield()
    {
        FindObjectOfType<AudioManager>().Play("PowerUp");
        shieldObj.gameObject.SetActive(true);
        Invoke("unshield", 5f);
    }
    //----------------------------------------------------------------------

    public void timeDown()
    {
        animasiEffect.SetBool("smaller", false);
        animasiEffect.SetBool("bigger", false);
    }
    public void unfly()
    {
        animasiEffect.SetBool("timeSlow", false);
        Time.timeScale = 1;
    }

    public void unturbo()
    {
        animasiEffect.SetBool("timeFast", false);
        Time.timeScale = 1;
        Mc.gravityScale = 2f;
    }
    public void unshield()
    {
        shieldObj.gameObject.SetActive(false);
    }
 
}
