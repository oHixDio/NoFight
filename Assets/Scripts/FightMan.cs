using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightMan : MonoBehaviour
{
    enum EDir { L,R,}

    [SerializeField]
    private EDir dir = EDir.L;

    [SerializeField]
    private float power = 1.0f;

    private bool isMove;

    private IGameState gameState;

    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip clip;


    void Start()
    {
        GetComponentInChildren<Camera>().enabled = false;
        gameState = GameManager.instace.GetComponent<IGameState>();
    }

    void Update()
    {
        if (gameState.GetCurrentGameState() == EGameState.FLY && !isMove)
        {
            isMove = true;
            audioSource.PlayOneShot(clip);
        }
    }

    private void FixedUpdate()
    {
        if (isMove)
        {
            // relativePosition‚ÌˆÚ“®
            transform.Translate(0, 0, 1 * -power * Time.deltaTime);
        }
    }

    void OnBecameInvisible()
    {
        Debug.Log("Hi");
        gameState.ChangeGameState(EGameState.CUTIN);
        GetComponentInChildren<Camera>().enabled = true;
    }

    
}
