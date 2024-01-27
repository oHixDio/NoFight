using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartButton : MonoBehaviour
{
    private IGameState gameState = null;
    private void Awake()
    {
        gameState = GameManager.instace.gameObject.GetComponent<IGameState>();
    }

    public void GameRestert()
    {
        gameState.ChangeGameState(EGameState.RESTART);
    }
}
