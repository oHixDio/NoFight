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

    private void Start()
    {
        BlowingLevel.CosmicFall_flag = false;
    }

    void Update()
    {
        //�ō����B�_
        if (BlowingLevel.level == BlowingLevel.Level.High && BlowingLevel.CosmicFall_flag)
        {
            //�J�����؂�ւ�
            mainCamera.gameObject.SetActive(false);
            subCamera.gameObject.SetActive(true);

            //�G�t�F�N�g�̔���
            backgroundEffects.gameObject.SetActive(true);
        }
    }
}
