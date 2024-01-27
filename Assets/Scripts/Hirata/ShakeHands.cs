using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeHands : MonoBehaviour
{
    //男たちが一定の地点に到達するとカメラが切り替わる
    //握手する2人が映される

    //吹き飛びレベルのスクリプタブルオブジェクト
    public BlowingLevel BlowingLevel;

    //カメラ
    [SerializeField] private GameObject mainCamera;
    [SerializeField] private GameObject subCamera;

    //エフェクトを内包するオブジェクト
    [SerializeField] private GameObject backgroundEffects;

    private void Start()
    {
        BlowingLevel.CosmicFall_flag = false;
    }

    void Update()
    {
        //最高到達点
        if (BlowingLevel.level == BlowingLevel.Level.High && BlowingLevel.CosmicFall_flag)
        {
            //カメラ切り替え
            mainCamera.gameObject.SetActive(false);
            subCamera.gameObject.SetActive(true);

            //エフェクトの発生
            backgroundEffects.gameObject.SetActive(true);
        }
    }
}
