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
    
    // Start is called before the first frame update

    public void Awake()
    {
        
    }
    void Start()
    {
      
        menuAnimator = GetComponent<Animator>();
        if (SoundManager.Instance.musicOn == false)
            SoundManager.Instance.MusicSource.Stop();
        else
        {   SoundManager.Instance.GameSource.Stop();
            SoundManager.Instance.PlayMusic(clip);
        }
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
            SoundManager.Instance.EffectsSource.Stop();
        else SoundManager.Instance.EffectsSource.Stop();
        
    }

    public void OnclickButtonStart()
    {
        if (SFX.isOn == true)
        {
            SoundManager.Instance.Play(buttonClicked);
        }
        else SoundManager.Instance.EffectsSource.UnPause();
        SceneTransition.SwitchToScene("Game");

     
    }
    
    public void OnSettingsClicked()
    {
        if (SFX.isOn == true)
        {
            SoundManager.Instance.Play(buttonClicked);

        }
        else SoundManager.Instance.EffectsSource.UnPause();
        menuAnimator.SetTrigger("setClicked");
        
    }

    public void InBackClicked()
    {
        if (SFX.isOn == true)
            SoundManager.Instance.Play(buttonClicked);
        else SoundManager.Instance.EffectsSource.UnPause();
        menuAnimator.SetTrigger("backClicked");
    }
}
