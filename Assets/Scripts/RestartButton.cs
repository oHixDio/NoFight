using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartButton : MonoBehaviour
{
    private IGameState gameState = null;

    //�C���X�y�N�^�[���SE��ݒ�
    public AudioSource audioSource;
    public AudioClip SE;

    private void Awake()
    {
        gameState = GameManager.instace.gameObject.GetComponent<IGameState>();

        //audioSource = GetComponent<AudioSource>();
    }

    public void GameRestert()
    {
        //�{�^�����������Ƃ���SE���Đ�
        audioSource.PlayOneShot(SE);

        gameState.ChangeGameState(EGameState.RESTART);
    }
}
