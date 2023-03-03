using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinsColect : MonoBehaviour
{
    public float value = 1;
    public TextMeshProUGUI CoinsText;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);

            collision.gameObject.GetComponent<PlayerControler>().coins += value;

            CoinsText.text = (" " + collision.gameObject.GetComponent<PlayerControler>().coins);
        }
    }

}
