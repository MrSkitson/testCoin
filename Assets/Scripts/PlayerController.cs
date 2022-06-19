using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator animator;
    private Rigidbody rigidbody;
    public float speed = 2f;
    public float rotationSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 directionvector = new Vector3(-v, 0, h);
        if (directionvector.magnitude > Mathf.Abs(0.05f));
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(directionvector), Time.deltaTime * 10);

        animator.SetFloat("speed", Vector3.ClampMagnitude(directionvector, 1).magnitude);

        
        rigidbody.velocity = Vector3.ClampMagnitude(directionvector, 1) * speed;

            }
}
