using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //Player
    private Transform Player;
    private Vector3 PlayerPos;


    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player").transform;
        PlayerPos = new Vector3(Player.position.x, Player.position.y, transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = PlayerPos;
    }
}
