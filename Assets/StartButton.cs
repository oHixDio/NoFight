using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    private IGameState gameState = null;

    //インスペクター上でSEを設定
    public AudioSource audioSource;
    public AudioClip SE;

    private void Awake()
    {
        gameState = GameManager.instace.gameObject.GetComponent<IGameState>();
        
    }

    public void GameStart()
    {
        //ボタンを押したときにSEを再生
        audioSource.PlayOneShot(SE);

        if (gameState == null) { return; }
        gameState.ChangeGameState(EGameState.START);
    }
}
