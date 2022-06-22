using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
   


   //public Toggle Music;
   //public Toggle SFX;
    public AudioClip clip;
    public Animator menuAnimator;
    // Start is called before the first frame update
    void Start()
    {
        menuAnimator = GetComponent<Animator>();
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
        SceneTransition.SwitchToScene("Game");
        //AudioScript.ASinstance.musicButton.Play();
        // AudioSource.PlayClipAtPoint(clip, transform.position); 
    }
    
    public void OnSettingsClicked()
    {
        menuAnimator.SetTrigger("setClicked");
    }

    public void InBackClicked()
    {
        menuAnimator.SetTrigger("backClicked");
    }
}
