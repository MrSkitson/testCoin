using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMover : MonoBehaviour
{
    public Vector3 startPosition;
    public Vector3 endPosition;
    public float step;
    private float progress;
    private float spawnRange = 3.5f;
    
    // Start is called before the first frame update
    void Start()
    {

        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        transform.position = startPosition;
        endPosition = new Vector3(spawnPosX, endPosition.y, spawnPosZ);
    }

    private void FixedUpdate()
    {
        transform.position = Vector2.Lerp(startPosition, endPosition, progress);
        progress += step;
        if(endPosition != null)
        Destroy(gameObject, 5.0f); 
    }
}
