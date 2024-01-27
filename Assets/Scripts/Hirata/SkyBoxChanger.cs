using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBoxChanger : MonoBehaviour
{
    //enumで設定したskyboxに変化する

    //使用するskyboxの数だけ設定する
    public enum changeSkyBox
    {
        normal = 0,
        cosmic
    }
    public changeSkyBox skyBox = changeSkyBox.normal;

    //スカイボックスの配列
    public Material[] skyBoxes;

    // Start is called before the first frame update
    void Start()
    {
        //設定したスカイボックスにオブジェクト出現時に変化する
        RenderSettings.skybox = skyBoxes[((int)skyBox)];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
