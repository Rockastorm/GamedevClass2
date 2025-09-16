using UnityEngine;

public class WASD_RB : MonoBehaviour
{
    //Variables
    public Rigidbody2D Rb2D;

    public float forceAmount = 1.75f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        //Attaches Rigidbody2D to the script is Rb2D
        Rb2D = GetComponent<Rigidbody2D>();
        

    }


    // Update is called once per frame
    void Update()
    {

        //Make the square move up when "W" is pressed
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {

            Rb2D.AddForce(Vector2.up * forceAmount);


        }

        //Make the square move down when "S" is pressed
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {

            Rb2D.AddForce(Vector2.down * forceAmount);


        }

        //Make the square move right when "D" is pressed
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {

            Rb2D.AddForce(Vector2.right * forceAmount);


        }

        //Make the square move up when "A" is pressed
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {

            Rb2D.AddForce(Vector2.left * forceAmount);


        }


    }


}
