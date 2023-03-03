using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCollect : MonoBehaviour
{
    //Value of Coin
    public float Value = 1;

    //Text
    public TextMeshProUGUI CoinAmountText;



    //Mehtods


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //destroy coin on collision with the player object
            Destroy(gameObject);

            //Update the Coin amount Text
            collision.gameObject.GetComponent<PlayerControler>().coins += Value;
            CoinAmountText.text = (" " + collision.gameObject.GetComponent<PlayerControler>().coins);
        }
    }


}
