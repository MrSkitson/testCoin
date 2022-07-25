using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioClip gameMusic;
    [SerializeField] private GameObject coin;
    [SerializeField] private GameObject player;
    [SerializeField] private float spawnRange = 4;
   
    public float speedC = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(player);
        InvokeRepeating("RespCoin", 2f, 3f);
        musicTurn(); 
    }


    public Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomSpown = new Vector3(spawnPosX, 5, spawnPosZ);

        return randomSpown;
    }

    public void RespCoin()
    {

        Instantiate(coin, GenerateSpawnPosition(), transform.rotation);
    }

    public void musicTurn()
    {
        if (SoundManager.Instance.musicOn)
        {
            SoundManager.Instance.MusicSource.Pause();
            SoundManager.Instance.PlayGameMusic(gameMusic);
        }
        else SoundManager.Instance.GameSource.Pause();


    }


}
