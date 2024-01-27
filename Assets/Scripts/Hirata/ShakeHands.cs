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

    //�G�t�F�N�g������I�u�W�F�N�g
    [SerializeField] private GameObject backgroundEffects;

    //�C���X�y�N�^�[���SE��ݒ�
    public AudioSource audioSource;
    public AudioClip SE;

    private void Start()
    {
        //�t���O�̏�����
        BlowingLevel.CosmicFall_flag = false;
    }

    void Update()
    {
        //�X���C�_�[���ő�
        if (BlowingLevel.level == BlowingLevel.Level.Great && BlowingLevel.CosmicFall_flag)
        {
            //�J�����؂�ւ�
            mainCamera.gameObject.SetActive(false);
            subCamera.gameObject.SetActive(true);

            //�G�t�F�N�g�̔���
            backgroundEffects.gameObject.SetActive(true);
            //SE���Đ�
            audioSource.PlayOneShot(SE);

            //���b�㎟�̏�ʂɐ؂�ւ���

        }
    }
}
