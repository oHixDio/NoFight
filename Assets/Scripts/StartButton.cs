using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    private IGameState gameState = null;

    private void Awake()
    {
        gameState = GameManager.instace.gameObject.GetComponent<IGameState>();
    }

    public void GameStart()
    {
        if (gameState == null) { return; }
        gameState.ChangeGameState(EGameState.START);
    }
}
