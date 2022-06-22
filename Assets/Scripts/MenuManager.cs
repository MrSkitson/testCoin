using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MenuManager : MonoBehaviour
{
    public AudioClip buttonClicked;
    
    public AudioClip clip;
    public Animator menuAnimator;
    
    // Start is called before the first frame update

    public void Awake()
    {
        SoundManager.Instance.musicOn = true;
       // SoundManager.Instance.PlayMusic(clip);
      SoundManager soundManager = GetComponent<SoundManager>();
    }
    void Start()
    {
        menuAnimator = GetComponent<Animator>();
        if (SoundManager.Instance.musicOn == false)
            SoundManager.Instance.MusicSource.Stop();
        else
            SoundManager.Instance.MusicSource.Play();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public  void MusicToggle()
    {
        if (SoundManager.Instance.MusicSource.isPlaying)
        {
            
            SoundManager.Instance.MusicSource.Stop();
            SoundManager.Instance.GameSource.mute = true;
            SoundManager.Instance.musicOn = false;
            
        }
            
        
        else
        {
            
            SoundManager.Instance.PlayMusic(clip);
            SoundManager.Instance.musicOn = true;
            // SoundManager.Instance.GameSource.mute = true;
            
        }
        

    }
    public void SFXToggle()
    {
        SoundManager.Instance.Play(buttonClicked);

        if (SoundManager.Instance.EffectsSource.isActiveAndEnabled)

            SoundManager.Instance.EffectsSource.Stop();
        else
        {
            SoundManager.Instance.EffectsSource.Play();
        }

        
    }

    public void OnclickButtonStart()
    {
        SoundManager.Instance.Play(buttonClicked);
        SceneTransition.SwitchToScene("Game");

     
    }
    
    public void OnSettingsClicked()
    {
        SoundManager.Instance.Play(buttonClicked);
        menuAnimator.SetTrigger("setClicked");
        
    }

    public void InBackClicked()
    {
        SoundManager.Instance.Play(buttonClicked);
        menuAnimator.SetTrigger("backClicked");
    }
}
