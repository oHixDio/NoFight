using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCosmicScene : MonoBehaviour
{
    //�F���ł̐�����я�ʂɈڍs�������̏���

    //�F���̃X�J�C�{�b�N�X
    public Material cosmicSkyBox;

    // Start is called before the first frame update
    void Start()
    {
        RenderSettings.skybox = cosmicSkyBox;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
