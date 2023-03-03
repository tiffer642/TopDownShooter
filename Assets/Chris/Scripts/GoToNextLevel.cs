using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToNextLevel : MonoBehaviour
{
    public GameManager gm;

    private void Start()
    {
        gm = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Goal"))
        {
            gm.LoadScene("SecondLevel");
        }
    }
}
