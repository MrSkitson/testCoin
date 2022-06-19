using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMechanics : MonoBehaviour
{
    public float speedMove = 1; //speed Player
    public float jumpPower; //forse jumping

    // Parametrs gameplay for player
    private float gravityForce;
    private Vector3 moveVector;

    
    //Components
    private CharacterController ch_controller;
    public Animator ch_animator;
    private Rigidbody rb;
    private MobileController mobileController;
    // Start is called before the first frame update
    void Start()
    {
        ch_controller = GetComponent<CharacterController>();
        ch_animator = GetComponent<Animator>();
        mobileController = GameObject.FindGameObjectWithTag("Joystick").GetComponent<MobileController>();
    }

    // Update is called once per frame
    void Update()
    {
        CharacterMove();
        GamingGravity();
        //MoveChar();
    }

    private void CharacterMove()
    {
        //movement on the ground
        if (ch_controller.isGrounded)
        {
            moveVector = Vector3.zero;
           // moveVector.x = Input.GetAxis("Horizontal") * speedMove;
          //  moveVector.z = Input.GetAxis("Vertical") * speedMove;

            moveVector.x = mobileController.Horizontal() * speedMove;
            moveVector.z = mobileController.Vertical() * speedMove;
            

            // animation movement character
            if (moveVector.x != 0 || moveVector.z != 0) ch_animator.SetBool("Move", true);
            else ch_animator.SetBool("Move", false);




            //rotate player model with angle movement
            if (Vector3.Angle(Vector3.forward, moveVector) > 1f || Vector3.Angle(Vector3.forward, moveVector) == 0)
            {
                Vector3 direct = Vector3.RotateTowards(transform.forward, moveVector, speedMove, 0.0f);
                transform.rotation = Quaternion.LookRotation(direct);
            }

            moveVector.y = gravityForce;
            //Method movement to side
            ch_controller.Move(moveVector * Time.deltaTime);
        }
    }

    //private void MoveChar()
    //{
    //    float h = Input.GetAxis("Horizontal") * speedMove;
    //    float v = Input.GetAxis("Vertical") * speedMove;
    //    Vector3 directionVector = new Vector3(-v, 0, h);
    //    ch_animator.SetFloat("Move", Vector3.ClampMagnitude(directionVector, 1).magnitude);
    //    rb.velocity = Vector3.ClampMagnitude(directionVector, 1) * speedMove;

    //}



    //method check if player isGrounded. And add some gravityForce
    private void GamingGravity()
    {
        if (!ch_controller.isGrounded) gravityForce -= 20f * Time.deltaTime;
        else gravityForce = -1f;
        
    }

}
