using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator animator;
    private Rigidbody rb;
    public float speed = 2f;
    public float rotationSpeed = 10f;

    private MobileController mobileController;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        
        mobileController = GameObject.FindGameObjectWithTag("Joystick").GetComponent<MobileController>();
    }

    // Update is called once per frame
    void Update()
    {

        PlayerMove();
    }


    private void PlayerMove()
    {
        //float h = Input.GetAxis("Horizontal");
        float h = mobileController.Horizontal();
        //float v = Input.GetAxis("Vertical");
       float v = mobileController.Vertical();
        Vector3 directionvector = new Vector3(-v, 0, h);
        if (directionvector.magnitude > Mathf.Abs(0.05f))
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(directionvector), Time.deltaTime * 10);
        }
        animator.SetFloat("speed", Vector3.ClampMagnitude(directionvector, 1).magnitude);


        rb.velocity = Vector3.ClampMagnitude(directionvector, 1) * speed;
    }
}
