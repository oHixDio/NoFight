using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeHands : MonoBehaviour
{
    //�j���������̒n�_�ɓ��B����ƃJ�������؂�ւ��
    //���肷��2�l���f�����

    //������у��x���̃X�N���v�^�u���I�u�W�F�N�g
    public BlowingLevel BlowingLevel;

    //�J����
    [SerializeField] private GameObject mainCamera;
    [SerializeField] private GameObject subCamera;

    [SerializeField] private GameObject resultCanvas;

    //�G�t�F�N�g������I�u�W�F�N�g
    [SerializeField] private GameObject backgroundEffects;

    //�C���X�y�N�^�[���SE��ݒ�
    public AudioSource audioSource;
    public AudioClip SE;

    //��ʑJ�ڂ܂ł̑ҋ@����
    private float waitTime = 5f;
    //�v������
    private float elapsedTime;

    private void Start()
    {
        //�t���O�̏�����
        BlowingLevel.isCosmicShift = false;
        BlowingLevel.CosmicFall_flag = false;
        resultCanvas.gameObject.SetActive(false);
    }

    void Update()
    {
        //�X���C�_�[���ő�
        if (BlowingLevel.level == BlowingLevel.Level.Great && BlowingLevel.CosmicFall_flag)
        {
            //�J�����؂�ւ�
            mainCamera.gameObject.SetActive(false);
            subCamera.gameObject.SetActive(true);
            Invoke("ShowResult", 3f);

            //�G�t�F�N�g�̔���
            backgroundEffects.gameObject.SetActive(true);
            //SE�̉��ʂ��傫�����ߒ��߂���
            audioSource.volume = 0.2f;
            //SE���Đ�
            audioSource.PlayOneShot(SE);

            //���b�㎟�̏�ʂɐ؂�ւ���
            //���Ԃ̌v��
            elapsedTime += Time.deltaTime;

            //�v�����Ԃ��ҋ@���Ԃ𒴂������ʑJ��
            if(elapsedTime > waitTime)
            {
                //SE�̉��ʐݒ�����ɖ߂�
                audioSource.volume = 1.0f;
                //���̏�ʂɑJ��
                //Debug.Log("��ʑJ�ځI�I�I");
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
