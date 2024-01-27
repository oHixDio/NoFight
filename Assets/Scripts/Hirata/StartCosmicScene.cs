using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCosmicScene : MonoBehaviour
{
    //宇宙での吹き飛び場面に移行した時の処理

    //宇宙のスカイボックス
    public Material cosmicSkyBox;

    // Start is called before the first frame update
    void Start()
    {
        RenderSettings.skybox = cosmicSkyBox;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
