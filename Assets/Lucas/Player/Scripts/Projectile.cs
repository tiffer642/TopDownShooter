using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    //Damage
    public float Dmg = 1;

    //Speed
    public float Speed = 1;

    //rigidBody
    private Rigidbody2D RB;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        StartCoroutine(AirTime());
    }

    // Update is called once per frame
    void Update()
    {
        RB.AddRelativeForce(Vector2.up * Speed, ForceMode2D.Impulse);

    }

    IEnumerator AirTime()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }

    //oncollision with enemy hurt enemy
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<EnemyController>().TakeDamage(Dmg);
        }
    }



}
