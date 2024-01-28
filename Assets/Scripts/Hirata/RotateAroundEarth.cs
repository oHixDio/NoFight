using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateAroundEarth : MonoBehaviour
{
    //���̒n�_�܂ŉ�]����ƃJ�������؂�ւ��j���������肷��
    //��]�ړ�����j�ɃA�^�b�`����

    //��]�̒��S�ƂȂ�I�u�W�F�N�g
    [SerializeField] private GameObject centerObject;
    // ���S�_
    [SerializeField] private Vector3 _center = Vector3.zero;
    // ��]��
    [SerializeField] private Vector3 _axis = Vector3.forward;
    // �~�^������
    [SerializeField] private float _period = 6;

    [SerializeField] private GameObject resultCanvas;
    [SerializeField] private GameObject resultText1;
    [SerializeField] private GameObject resultText2;

    //��]�̒�~����n�_
    private float stopRotatePos_Max = -5.4f;
    private float stopRotatePos_Medium = -2f;

    //�����̃p�[�e�B�N�����ݒ肳�ꂽ�I�u�W�F�N�g
    [SerializeField] private GameObject explosion;
    private bool isexplosion = false;

    //�C���X�y�N�^�[���SE��ݒ�
    public AudioSource audioSource;
    public AudioClip SE;
    public AudioClip BlowingSE;

    //������у��x���̃X�N���v�^�u���I�u�W�F�N�g
    public BlowingLevel BlowingLevel;

    private void Start()
    {
        _center = centerObject.transform.position;
    }
    private void Update()
    {
        //���̃X�N���v�g����t���O��true�ɂ���Ɠ���
        if (BlowingLevel.isCosmicShift)
        {
            RotateAroundEarthGays();
        }
    }

    //�����̏��������\�b�h�ɂ��ĊǗ����₷������
    public void RotateAroundEarthGays()
    {
        //�X���C�_�[���������̒n�_�܂ŉ�]����Ɠ���
        if (transform.position.y < stopRotatePos_Medium && BlowingLevel.level == BlowingLevel.Level.Good)
        {
            //audio�̃��[�v�ݒ�����ɖ߂�
            AudioLoopReverse();

            //�F���ł̃C�x���g���N���Ă��Ȃ�������������
            if (!BlowingLevel.CosmicFall_flag)
            {
                //true�ɂ��Ĕ���������
                BlowingLevel.CosmicFall_flag = true;
            }
        }
        //�X���C�_�[���ő傩���̒n�_�܂ŉ�]����Ɠ���
        else if (transform.position.y < stopRotatePos_Max && BlowingLevel.level == BlowingLevel.Level.Great)
        {
            //audio�̃��[�v�ݒ�����ɖ߂�
            AudioLoopReverse();

            //�t���O��ς��ăJ������؂�ւ���
            if (!BlowingLevel.CosmicFall_flag) BlowingLevel.CosmicFall_flag = true;
        }
        else
        {
            //��]���s�킸�ɉ~���ړ����s������
            var tr = transform;
            // ��]�̃N�H�[�^�j�I���쐬
            var angleAxis = Quaternion.AngleAxis(360 / _period * Time.deltaTime, _axis);

            // �~�^���̈ʒu�v�Z
            var pos = tr.position;

            pos -= _center;
            pos = angleAxis * pos;
            pos += _center;

            tr.position = pos;


            if (audioSource.loop == false)
            {
                //������Ԏ���SE���Đ��@���̎�audio�����[�v�ݒ�ɕς���
                audioSource.loop = true;
                //SE���Đ�
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
        //�������邩�m�F
        explosionCosmic();
    }

    //��x���������𔭐�������
    public void explosionCosmic()
    {
        //�F���ł̃t���O��true�ɂȂ�Ɠ���
        if (BlowingLevel.CosmicFall_flag)
        {
            if (!isexplosion)
            {
                //�����̃I�u�W�F�N�g�𐶐�
                Instantiate(explosion, transform.position, Quaternion.identity);
                //SE���Đ�
                audioSource.PlayOneShot(SE);

                //�l���\���ɂ���
                gameObject.SetActive(false);

                //true�ɂ��čēx�������Ȃ��悤�ɂ���
                isexplosion = true;


                //���b�㎟�̏�ʂɐ؂�ւ���
                resultCanvas.SetActive(true);
                resultText1.SetActive(false);
                resultText2.SetActive(true);
            }
        }
    }

    //audio�����[�v�ݒ��߂�
    private void AudioLoopReverse()
    {
        //audio�����[�v�ݒ肪true�̎�false�ɂ���
        if (audioSource.loop == true) audioSource.loop = false;
    }
}
