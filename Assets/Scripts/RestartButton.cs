using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartButton : MonoBehaviour
{
    private IGameState gameState = null;

    //インスペクター上でSEを設定
    public AudioSource audioSource;
    public AudioClip SE;

    private void Awake()
    {
        gameState = GameManager.instace.gameObject.GetComponent<IGameState>();

        //audioSource = GetComponent<AudioSource>();
    }

    public void GameRestert()
    {
        //ボタンを押したときにSEを再生
        audioSource.PlayOneShot(SE);

        gameState.ChangeGameState(EGameState.RESTART);
    }
}
