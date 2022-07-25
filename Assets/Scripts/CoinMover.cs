using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMover : MonoBehaviour
{
    
    [SerializeField]private Vector3 startPosition;
    private Vector3 endPosition;
    private float step;
    private float progress;
    // set max and min number for declare spawnPosX and Y
    private float spawnRange = 3.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        //get start posotion Coin 
        transform.position = startPosition;
        //set end position  Coin
        endPosition = new Vector3(spawnPosX, 1.5f, spawnPosZ);
    }

    private void FixedUpdate()
    {
        //Moving Coin to end position
        transform.position = Vector2.Lerp(startPosition, endPosition, progress);
        progress += step;
        //Destiroy Coin in 5 sec
        if(endPosition != null)
                Destroy(gameObject, 5.0f); 
    }
}
