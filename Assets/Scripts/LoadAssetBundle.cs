using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssetBundle : MonoBehaviour
{
    string url = "https://drive.google.com/uc?export=download&id=1JqvGVS3e18zcR60FWGeCMvtjc5pvRSNv"; //LINk google
    // Start is called before the first frame update
    void Start()
    {
        WWW wWW = new WWW(url);
        StartCoroutine(WebReq(wWW));
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
            GameObject obj = bundle.LoadAsset("xbot") as GameObject;
            
            Instantiate(obj);
            bundle.Unload(false);

        }
        else
        {
            Debug.Log(wWW.error);
        }

    }
}
