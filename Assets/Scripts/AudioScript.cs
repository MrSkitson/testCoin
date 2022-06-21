using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    public static AudioScript ASinstance;
    public  AudioSource Music;
    





    public void Awake()
    {
        if(ASinstance != null && ASinstance != this)
        {
            Destroy(this.gameObject);
            return;
;        }

        ASinstance = this;
       // DontDestroyOnLoad(this);
    }

    private void Start()
    {
        Music = GetComponent<AudioSource>();
       
    }
}
