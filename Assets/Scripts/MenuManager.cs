using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
   


   //public Toggle Music;
   //public Toggle SFX;
    public AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public  void MusicToggle()
    {
        if (AudioScript.ASinstance.Music.isPlaying)
        {
            AudioScript.ASinstance.Music.Pause();

        }
        else
        {
            AudioScript.ASinstance.Music.Play();
        }
    }
    public void OnclickButtonStart()
    {
        //AudioScript.ASinstance.musicButton.Play();
        AudioSource.PlayClipAtPoint(clip, transform.position); 
    }
}
