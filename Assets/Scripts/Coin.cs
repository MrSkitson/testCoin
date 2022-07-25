using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private float turnSpeed = 90f;
    [SerializeField] private Vector2 direction;
    [SerializeField] private float speedCoin;

    private void FixedUpdate()
    {
      RotateCoin();
    }
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Player")
        {
            return;
        }
        Destroy(gameObject);
    }

    private void RotateCoin()
    {
        transform.Rotate(0, 0, turnSpeed * Time.deltaTime);
    }

    

}
