using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CosmicSequence : MonoBehaviour
{
    [SerializeField] private Fade fade;
    private IGameState gameState;
    private void Start()
    {
        gameState = GameManager.instace.GetComponent<IGameState>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            fade.FadeOut();
            Invoke("ChangeState", 3f);
        }
    }

    private void ChangeState()
    {
        gameState.ChangeGameState(EGameState.COSMIC);
    }
}
