using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class WASD_RD_CUSTOM : MonoBehaviour
{
    //Variables
    public float speed;

    private Vector2 position;

    public InputActionReference movement;

    // Update is called once per frame
    void Update()
    {

        position = transform.position;


        if (Input.GetKey(KeyCode.W))
        {

            position.y += speed * Time.deltaTime;


        }
        if (Input.GetKey(KeyCode.S))
        {

            position.y -= speed * Time.deltaTime;


        }

        if (Input.GetKey(KeyCode.D))
        {

            position.x += speed * Time.deltaTime;


        }
        if (Input.GetKey(KeyCode.A))
        {

            position.x -= speed * Time.deltaTime;


        }


        transform.position = position;


    }


}
