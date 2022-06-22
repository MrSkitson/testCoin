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
        
        SoundManager.Instance.PlayMusic(clip);
    }
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
        if (SoundManager.Instance.MusicSource.isPlaying)
        {
            SoundManager.Instance.musicOff = true;
            SoundManager.Instance.MusicSource.Stop();
            SoundManager.Instance.GameSource.Stop();

        }
            
        
        else
        {
            
            SoundManager.Instance.PlayMusic(clip);
            SoundManager.Instance.musicOff = false;

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
