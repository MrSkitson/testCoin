using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMover : MonoBehaviour
{
    public Vector3 startPosition;
    public Vector3 endPosition;
    public float step;
    private float progress;
    private float spawnRange = 4f;
    bool CoinsStop = false;
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
        if (step > 0)
            CoinsStop = true;
        // Destroy coin between 5 sec if endPosition
        if (CoinsStop = true)
        Destroy(gameObject, 5.0f); 
    }
}
