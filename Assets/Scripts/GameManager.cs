using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioClip gameMusic;
    [SerializeField] private GameObject coin;
    [SerializeField] private GameObject player;
        private float spawnRange = 4;
   
    
    public float speedC = 0.05f;

    public void Awake()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(player);
        InvokeRepeating("RespCoin", 2f, 3f);


        if (SoundManager.Instance.musicOn)
        {
            SoundManager.Instance.MusicSource.Pause();
            SoundManager.Instance.PlayGameMusic(gameMusic);
        }
        else SoundManager.Instance.GameSource.Pause();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomSpown = new Vector3(spawnPosX, 5, spawnPosZ);

        return randomSpown;
    }

    void RespCoin()
    {

        Instantiate(coin, GenerateSpawnPosition(), transform.rotation);
        

        //coin.gameObject.transform.position = new Vector3(transform.position.x, 1, transform.position.z) * speedC;


        //Destroy(gameObject, timeout);


    }
}
