using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundEarth : MonoBehaviour
{
    //一定の地点まで回転するとカメラが切り替わり男たちが握手する
    //回転移動する男にアタッチする

    //中心点
    [SerializeField] private Vector3 center = Vector3.zero;
    //回転軸
    [SerializeField] private Vector3 axis = Vector3.up;
    //円運動周期
    [SerializeField] private float _period = 2;

    //回転の停止する地点
    private float stopRotatePos_Max = -5.4f;

    //吹き飛びレベルのスクリプタブルオブジェクト
    public BlowingLevel BlowingLevel;

    private void Update()
    {
        
        //中心点centerの周りを、軸axisで、period周期で円運動
        transform.RotateAround(
            center,
            axis,
            360 / _period * Time.deltaTime
        );

        //スライダーが最大かつ一定の地点まで回転すると動作
        if (transform.position.y < stopRotatePos_Max && BlowingLevel.level == BlowingLevel.Level.High)
        {
            //フラグを変えてカメラを切り替える
            if (!BlowingLevel.CosmicFall_flag) BlowingLevel.CosmicFall_flag = true;
        }
    }
}
