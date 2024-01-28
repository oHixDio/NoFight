using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateAroundEarth : MonoBehaviour
{
    //一定の地点まで回転するとカメラが切り替わり男たちが握手する
    //回転移動する男にアタッチする

    //回転の中心となるオブジェクト
    [SerializeField] private GameObject centerObject;
    // 中心点
    [SerializeField] private Vector3 _center = Vector3.zero;
    // 回転軸
    [SerializeField] private Vector3 _axis = Vector3.forward;
    // 円運動周期
    [SerializeField] private float _period = 6;

    [SerializeField] private GameObject resultCanvas;
    [SerializeField] private GameObject resultText1;
    [SerializeField] private GameObject resultText2;

    //回転の停止する地点
    private float stopRotatePos_Max = -5.4f;
    private float stopRotatePos_Medium = -2f;

    //爆発のパーティクルが設定されたオブジェクト
    [SerializeField] private GameObject explosion;
    private bool isexplosion = false;

    //インスペクター上でSEを設定
    public AudioSource audioSource;
    public AudioClip SE;
    public AudioClip BlowingSE;

    //吹き飛びレベルのスクリプタブルオブジェクト
    public BlowingLevel BlowingLevel;

    private void Start()
    {
        _center = centerObject.transform.position;
    }
    private void Update()
    {
        //他のスクリプトからフラグをtrueにすると動作
        if (BlowingLevel.isCosmicShift)
        {
            RotateAroundEarthGays();
        }
    }

    //根幹の処理をメソッドにして管理しやすくする
    public void RotateAroundEarthGays()
    {
        //スライダーが強かつ一定の地点まで回転すると動作
        if (transform.position.y < stopRotatePos_Medium && BlowingLevel.level == BlowingLevel.Level.Good)
        {
            //audioのループ設定を元に戻す
            AudioLoopReverse();

            //宇宙でのイベントが起きていない時発生させる
            if (!BlowingLevel.CosmicFall_flag)
            {
                //trueにして爆発させる
                BlowingLevel.CosmicFall_flag = true;
            }
        }
        //スライダーが最大かつ一定の地点まで回転すると動作
        else if (transform.position.y < stopRotatePos_Max && BlowingLevel.level == BlowingLevel.Level.Great)
        {
            //audioのループ設定を元に戻す
            AudioLoopReverse();

            //フラグを変えてカメラを切り替える
            if (!BlowingLevel.CosmicFall_flag) BlowingLevel.CosmicFall_flag = true;
        }
        else
        {
            //回転を行わずに円周移動を行う処理
            var tr = transform;
            // 回転のクォータニオン作成
            var angleAxis = Quaternion.AngleAxis(360 / _period * Time.deltaTime, _axis);

            // 円運動の位置計算
            var pos = tr.position;

            pos -= _center;
            pos = angleAxis * pos;
            pos += _center;

            tr.position = pos;


            if (audioSource.loop == false)
            {
                //吹き飛ぶ時のSEを再生　この時audioをループ設定に変える
                audioSource.loop = true;
                //SEを再生
                audioSource.PlayOneShot(BlowingSE);
            }
        }

        float result = GameManager.instace.Result;
        if (result < 10)
        {
            BlowingLevel.level = BlowingLevel.Level.Good;
        }
        else
        {
            BlowingLevel.level = BlowingLevel.Level.Great;
        }
        //爆発するか確認
        explosionCosmic();
    }

    //一度だけ爆発を発生させる
    public void explosionCosmic()
    {
        //宇宙でのフラグがtrueになると動作
        if (BlowingLevel.CosmicFall_flag)
        {
            if (!isexplosion)
            {
                //爆発のオブジェクトを生成
                Instantiate(explosion, transform.position, Quaternion.identity);
                //SEを再生
                audioSource.PlayOneShot(SE);

                //人を非表示にする
                gameObject.SetActive(false);

                //trueにして再度発生しないようにする
                isexplosion = true;


                //数秒後次の場面に切り替える
                resultCanvas.SetActive(true);
                resultText1.SetActive(false);
                resultText2.SetActive(true);
            }
        }
    }

    //audioをループ設定を戻す
    private void AudioLoopReverse()
    {
        //audioをループ設定がtrueの時falseにする
        if (audioSource.loop == true) audioSource.loop = false;
    }
}
