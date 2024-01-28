using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slidermove : MonoBehaviour
{
    private IGameState gameState = null;
    [SerializeField] float BarSpeed = 1f;
    [SerializeField] Slider Slider;
    [SerializeField] private float nextStateTime = 5f;
    public AudioClip sound1;
    AudioSource audioSource;

    public float FlyingDistance;
    private bool isClicked;

    // Start is called before the first frame update
    void Start()
    {
        gameState = GameManager.instace.GetComponent<IGameState>();
        audioSource = GetComponent<AudioSource>();
        Slider.value = 0;
        isClicked = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            audioSource.PlayOneShot(sound1);
        }
        //��x�N���b�N�����炱���̏����͎g��Ȃ����烊�^�[������
        if (isClicked)
        {
            return;
        }
        if (Input.GetMouseButtonDown(0) && isClicked == false)
        {
            SliderStop();
        }

        //�����ŃX���C�_�[�̐��l��ύX���Ă��܂�
        if (Slider.value == 10 || Slider.value ==0)
        {
            BarSpeed *= -1;  
        }
        //��������o�[�̑���
        Slider.value += BarSpeed * Time.deltaTime;
    }
    private void SliderStop()
    {
        //�X�e�[�g�̕ύX�����Ă��܂�
        isClicked = true;
        Invoke("callState", nextStateTime);
        audioSource.PlayOneShot(sound1);

        //���U���g�̒l�������Ō��߂Ă��܂�
        if (Slider.value >= 4.5 && Slider.value <= 5.5)
        {
            FlyingDistance = 10;
            GameManager.instace.Result = FlyingDistance;
        }

        else if (Slider.value >= 2.0 && Slider.value <= 4.5 || Slider.value >= 5.5 && Slider.value <= 8.0)
        {
            FlyingDistance = 5;
            GameManager.instace.Result = FlyingDistance;
        }

        else if (Slider.value >= 0.0 && Slider.value <= 2.0 || Slider.value >= 8.0 && Slider.value <= 10.0)

        {
            FlyingDistance = 1;
            GameManager.instace.Result = FlyingDistance;
        };

    }
    private void callState()
    {
        gameState.ChangeGameState(EGameState.FLY);
    }
}