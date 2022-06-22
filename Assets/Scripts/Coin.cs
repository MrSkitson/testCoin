using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private float turnSpeed = 90f;
    [SerializeField] private Vector2 direction;
    public float speedCoin;

    // Update is called once per frame
    void Update()
    {
        
        
       //transform.Translate(direction * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        //if (transform.position.y != 1)
        //{
        //  //  transform.Translate(direction.normalized * speedCoin);
        //} 
        transform.Rotate(0, 0, turnSpeed * Time.deltaTime);
    }
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Player")
        {
            return;
        }
        Destroy(gameObject);
    }

    

}
