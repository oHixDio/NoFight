using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour
{
    [SerializeField] private Color color = new Color(0, 0, 0);
    [SerializeField] private float fadeTime = 3.0f;
    [SerializeField] private int loopCnt = 20;

    IEnumerator Color_FadeIn()
    {
        // ��ʂ��t�F�[�h�C��������R�[���`��
        // �O��F��ʂ𕢂�Panel�ɃA�^�b�`���Ă���

        // �F��ς���Q�[���I�u�W�F�N�g����Image�R���|�[�l���g���擾
        Image fade = GetComponent<Image>();
        fade.enabled = true;
        // �t�F�[�h���̐F��ݒ�i���j���ύX��
        fade.color = color;

        // �t�F�[�h�C���ɂ����鎞�ԁi�b�j���ύX��
        float fade_time = fadeTime;

        // ���[�v�񐔁i0�̓G���[�j���ύX��
        int loop_count = loopCnt;
        if (loop_count == 0) {  loop_count = 1; }

        // �E�F�C�g���ԎZ�o
        float wait_time = fade_time / loop_count;

        // �F�̊Ԋu���Z�o
        float alpha_interval = 255.0f / loop_count;

        // �F�����X�ɕς��郋�[�v
        for (float alpha = 255.0f; alpha >= 0.0f; alpha -= alpha_interval)
        {
            // �҂�����
            yield return new WaitForSeconds(wait_time);

            // Alpha�l��������������
            Color new_color = fade.color;
            new_color.a = alpha / 255.0f;
            fade.color = new_color;
        }
        fade.enabled = false;
    }

    IEnumerator Color_FadeOut()
    {
        
        // ��ʂ��t�F�[�h�C��������R�[���`��
        // �O��F��ʂ𕢂�Panel�ɃA�^�b�`���Ă���

        // �F��ς���Q�[���I�u�W�F�N�g����Image�R���|�[�l���g���擾
        Image fade = GetComponent<Image>();
        fade.enabled = true;
        // �t�F�[�h���̐F��ݒ�i���j���ύX��
        fade.color = color;

        // �t�F�[�h�C���ɂ����鎞�ԁi�b�j���ύX��
        float fade_time = fadeTime / 2;

        // ���[�v�񐔁i0�̓G���[�j���ύX��
        int loop_count = loopCnt;
        if (loop_count == 0) { loop_count = 1; }

        // �E�F�C�g���ԎZ�o
        float wait_time = fade_time / loop_count;

        // �F�̊Ԋu���Z�o
        float alpha_interval = 255.0f / loop_count;

        // �F�����X�ɕς��郋�[�v
        for (float alpha = 0f; alpha <= 255.0f; alpha += alpha_interval)
        {
            // �҂�����
            yield return new WaitForSeconds(wait_time);

            // Alpha�l��������������
            Color new_color = fade.color;
            new_color.a = alpha / 255.0f;
            fade.color = new_color;
        }
        fade.color = color;
    }

    public void FadeIn()
    {
        StartCoroutine("Color_FadeIn");
    }

    public void FadeOut()
    {
        StartCoroutine("Color_FadeOut");
    }
}
