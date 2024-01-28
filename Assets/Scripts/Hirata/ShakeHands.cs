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

    [SerializeField] private GameObject resultCanvas;

    //エフェクトを内包するオブジェクト
    [SerializeField] private GameObject backgroundEffects;

    //インスペクター上でSEを設定
    public AudioSource audioSource;
    public AudioClip SE;

    //場面遷移までの待機時間
    private float waitTime = 5f;
    //計測時間
    private float elapsedTime;

    private void Start()
    {
        //フラグの初期化
        BlowingLevel.isCosmicShift = false;
        BlowingLevel.CosmicFall_flag = false;
        resultCanvas.gameObject.SetActive(false);
    }

    void Update()
    {
        //スライダーが最大
        if (BlowingLevel.level == BlowingLevel.Level.Great && BlowingLevel.CosmicFall_flag)
        {
            //カメラ切り替え
            mainCamera.gameObject.SetActive(false);
            subCamera.gameObject.SetActive(true);
            Invoke("ShowResult", 3f);

            //エフェクトの発生
            backgroundEffects.gameObject.SetActive(true);
            //SEの音量が大きいため調節する
            audioSource.volume = 0.2f;
            //SEを再生
            audioSource.PlayOneShot(SE);

            //数秒後次の場面に切り替える
            //時間の計測
            elapsedTime += Time.deltaTime;

            //計測時間が待機時間を超えたら場面遷移
            if(elapsedTime > waitTime)
            {
                //SEの音量設定を元に戻す
                audioSource.volume = 1.0f;
                //次の場面に遷移
                //Debug.Log("場面遷移！！！");
                IGameState gameState = GameManager.instace.GetComponent<IGameState>();
                gameState.ChangeGameState(EGameState.RESULT);
            }
        }
    }
    
    private void ShowResult()
    {
        resultCanvas.gameObject.SetActive(true);
    }
}
