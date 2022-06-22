using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUIscript : MonoBehaviour
{
    static int coin;
    [SerializeField] private Texture icon;
    
    
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
       GUI.Label(new Rect(50, 20, 80, 60), new GUIContent(" " + coin, icon));

        //Button menu

        if (GUI.Button(new Rect(Screen.width - 100, 20, 100, 50), "Menu"))
        {
            
            SceneTransition.SwitchToScene("Menu");
            //SceneManager.LoadScene("Menu");
            // Application.LoadLevel("Menu");
            
        }

    }
    public void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Coin")
        {
            
            coin++;
            Destroy(collision.gameObject);
           
        }
    }
}
