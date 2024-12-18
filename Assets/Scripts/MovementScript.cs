using UnityEngine;
using UnityEngine.InputSystem;



public class MovementScript : MonoBehaviour
{
    private Rigidbody rb;
    private float movementX;
    private float movementY;
    public float speed = 0;




    void Start()
    {
        rb = GetComponent<Rigidbody>();



    }




    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();



        movementX = movementVector.x;
        movementY = movementVector.y;





    }



    void FixedUpdate()
    {
        //perform a task and wont return any value
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);



    }



}