using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUIscript : MonoBehaviour
{
    static int score;
    public Texture icon;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnGUI()
    {


        //Label showing actual score
        //if I find a texture for Coin
        GUI.Label(new Rect(50, 30, 80, 60), new GUIContent("Coins " + score, icon));
       // GUI.Label(new Rect(20, 30, 80, 50), ("Coins: " + score));

        //Button menu

        if (GUI.Button(new Rect(Screen.width - 100, 25, 100, 50), "Menu"))
        {
            SceneManager.LoadScene("Menu");
            // Application.LoadLevel("Menu");
            
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        //place to add cillosion beetwen player and coin
    }
}
