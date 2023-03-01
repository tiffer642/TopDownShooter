using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    //Rotation
    private Vector3 mouse_pos;
    private Transform target;
    private Vector3 object_pos;
    private float angle;
    public bool isLocal;


    //Movement
    private float HorizontalInput;
    private float VerticalInput;
    public float moveSpeed = 5;



    // Start is called before the first frame update
    void Start()
    {
        target = transform;
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


    void Rotation()
    {
        
            mouse_pos = Input.mousePosition;
            mouse_pos.z = -20;
            object_pos = Camera.main.WorldToScreenPoint(target.position);
            mouse_pos.x = mouse_pos.x - object_pos.x;
            mouse_pos.y = mouse_pos.y - object_pos.y;
            angle = Mathf.Atan2(mouse_pos.y, mouse_pos.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, 0, angle);
        
    }

}
