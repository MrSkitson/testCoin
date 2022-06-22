using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssetBundle : MonoBehaviour
{
    string url = ""; //LINk google
    // Start is called before the first frame update
    void Start()
    {
        WWW wWW = new WWW(url);
    }

  IEnumerator WebReq(WWW wWW)
    {
        yield return wWW;

        while(wWW.isDone == false)
        {
            yield return null;
        }

        AssetBundle bundle = wWW.assetBundle;
        if(wWW.error == null)
        {
            GameObject obj = (GameObject)bundle.LoadAsset("");
            
        }
        else
        {
            Debug.Log(wWW.error);
        }

    }
}
