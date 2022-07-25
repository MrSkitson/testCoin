using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MenuManager : MonoBehaviour
{
    public AudioClip buttonClicked;
    public Toggle Music;
    public Toggle SFX;
    public AudioClip clip;
    public Animator menuAnimator;
  
    void Start()
    {
      
        menuAnimator = GetComponent<Animator>();
        MenuMusic();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public  void MusicToggle()
    {

        if (Music.isOn == false)
        {
            SoundManager.Instance.MusicSource.Stop();
            SoundManager.Instance.musicOn = false;
        }
        else
        {
            SoundManager.Instance.PlayMusic(clip);
            SoundManager.Instance.musicOn = true;
        }

    }
    public void SFXToggle()
    {
        if (SFX.isOn == false)
        {
            SoundManager.Instance.EffectsSource.Stop();
            SoundManager.Instance.sfxOn = false;
        }
        else
        {
            SoundManager.Instance.EffectsSource.Stop();
            SoundManager.Instance.sfxOn = true;
        }
    }

    public void OnclickButtonStart()
    {
        if (SFX.isOn == true)
        {
            SoundManager.Instance.Play(buttonClicked);
        }
        else { SoundManager.Instance.EffectsSource.UnPause();
            }
       
        SceneTransition.SwitchToScene("Game");

     
    }
    
    public void OnSettingsClicked()
    {

        if (!SoundManager.Instance.musicOn)
        {
            Music.isOn = false;
        }
       if(!SoundManager.Instance.sfxOn)
        {
            SFX.isOn = false;
        }
        

        if (SFX.isOn == true)
            {
                SoundManager.Instance.Play(buttonClicked);

            }
            else  SoundManager.Instance.EffectsSource.UnPause();
                
            
        menuAnimator.SetTrigger("setClicked");
        
    }

    public void InBackClicked()
    {
        if (SFX.isOn == true)
            SoundManager.Instance.Play(buttonClicked);
        else SoundManager.Instance.EffectsSource.UnPause();
        menuAnimator.SetTrigger("backClicked");
    }
    //Method for controlling staytment music in game
    private void MenuMusic()
    {

        if (SoundManager.Instance.musicOn == false)
            SoundManager.Instance.MusicSource.Stop();
        else
        {
            SoundManager.Instance.GameSource.Stop();
            SoundManager.Instance.PlayMusic(clip);
        }
    }

}
