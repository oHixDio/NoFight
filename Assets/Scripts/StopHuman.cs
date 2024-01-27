using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class StopHuman : MonoBehaviour
{
    [SerializeField] private float fallSpeed = 1.0f;
    private IGameState gameState;

    private bool fallFlag = true;

    //�C���X�y�N�^�[���SE��ݒ�
    public AudioSource audioSource;
    public AudioClip SE;
    private bool oneSound = false;

    // Start is called before the first frame update
    void Start()
    {
        gameState = GameManager.instace.gameObject.GetComponent<IGameState>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameState.GetCurrentGameState() == EGameState.START && fallFlag)
        {
            transform.Translate(0, -fallSpeed * Time.deltaTime, 0);

            //�j�����n����
            if (transform.position.y < 0)
            {
                if (!oneSound)
                {
                    oneSound = true;
                    //�{�^�����������Ƃ���SE���Đ�
                    audioSource.PlayOneShot(SE);
                }

                transform.position = Vector3.zero;
                fallFlag = false;
            }
        }
    }
}
