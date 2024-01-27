using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CosmicSequence : MonoBehaviour
{
    private IGameState gameState;
    private void Start()
    {
        gameState = GameManager.instace.GetComponent<IGameState>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameState.ChangeGameState(EGameState.COSMIC);
        }
    }
}
