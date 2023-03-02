using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControler : MonoBehaviour
{
    //Movement
    private float HorizontalInput;
    private float VerticalInput;
    public float moveSpeed = 5;


    //Health
    public float HP = 100;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }


    void Movement()
    {
        //Detect input
        HorizontalInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector2.up * moveSpeed * Time.deltaTime * VerticalInput);
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime * HorizontalInput);


    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Hit(100); //Change to collision.gameObject.GetComponent<  -EnemyAI Script-  >().DMG;
        }
    }


    public void Hit(float Dmg) //Dmg Damage an enemy does.
    {
        HP -= 100;  //Change to the damage of the enemy;
        if (HP <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Debug.Log("Dead");
        }
    }


}
