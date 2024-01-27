using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    private IGameState gameState = null;

    //�C���X�y�N�^�[���SE��ݒ�
    public AudioSource audioSource;
    public AudioClip SE;

    private void Awake()
    {
        gameState = GameManager.instace.gameObject.GetComponent<IGameState>();
        
    }

    public void GameStart()
    {
        //�{�^�����������Ƃ���SE���Đ�
        audioSource.PlayOneShot(SE);

        if (gameState == null) { return; }
        gameState.ChangeGameState(EGameState.START);
    }
}
