using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundEarth : MonoBehaviour
{
    //���̒n�_�܂ŉ�]����ƃJ�������؂�ւ��j���������肷��
    //��]�ړ�����j�ɃA�^�b�`����

    //���S�_
    [SerializeField] private Vector3 center = Vector3.zero;
    //��]��
    [SerializeField] private Vector3 axis = Vector3.up;
    //�~�^������
    [SerializeField] private float _period = 2;

    //��]�̒�~����n�_
    private float stopRotatePos_Max = -5.4f;

    //������у��x���̃X�N���v�^�u���I�u�W�F�N�g
    public BlowingLevel BlowingLevel;

    private void Update()
    {
        
        //���S�_center�̎�����A��axis�ŁAperiod�����ŉ~�^��
        transform.RotateAround(
            center,
            axis,
            360 / _period * Time.deltaTime
        );

        //�X���C�_�[���ő傩���̒n�_�܂ŉ�]����Ɠ���
        if (transform.position.y < stopRotatePos_Max && BlowingLevel.level == BlowingLevel.Level.High)
        {
            //�t���O��ς��ăJ������؂�ւ���
            if (!BlowingLevel.CosmicFall_flag) BlowingLevel.CosmicFall_flag = true;
        }
    }
}
