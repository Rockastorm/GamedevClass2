using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class WASD_RB_CUSTOM_NEW : MonoBehaviour
{
    //Variables

    public float Speed;

    private Vector3 position;

    public InputActionReference movement;

    // Update is called once per frame
    void Update()
    {

        position = movement.action.ReadValue<Vector2>() * Speed * Time.deltaTime;

        transform.position += position;


    }


}
