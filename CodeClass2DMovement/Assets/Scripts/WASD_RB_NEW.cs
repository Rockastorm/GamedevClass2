using UnityEngine;
using UnityEngine.InputSystem;

public class WASD_RB_NEW : MonoBehaviour
{
    //Variables
    public Rigidbody2D rb;

    public float moveSpeed;
    private Vector2 _movedirection;

    public InputActionReference move;


    // Update is called once per frame
    void Update()
    {
        
        _movedirection = move.action.ReadValue<Vector2>();


    }


    private void FixedUpdate()
    {

        rb.linearVelocity = new Vector2(x:_movedirection.x * moveSpeed,y:_movedirection.y * moveSpeed);


    }


}
