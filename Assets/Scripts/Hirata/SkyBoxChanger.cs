using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBoxChanger : MonoBehaviour
{
    //enum�Őݒ肵��skybox�ɕω�����

    //�g�p����skybox�̐������ݒ肷��
    public enum changeSkyBox
    {
        normal = 0,
        cosmic
    }
    public changeSkyBox skyBox = changeSkyBox.normal;

    //�X�J�C�{�b�N�X�̔z��
    public Material[] skyBoxes;

    // Start is called before the first frame update
    void Start()
    {
        //�ݒ肵���X�J�C�{�b�N�X�ɃI�u�W�F�N�g�o�����ɕω�����
        RenderSettings.skybox = skyBoxes[((int)skyBox)];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
