using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour, IGameState
{
    private EGameState state;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void ChangeGameState(EGameState newState)
    {
        ExitGameState(state);
        state = newState;
        EntryGameState(state);
    }

    public void EntryGameState(EGameState curState)
    {
        switch (curState)
        {
            case EGameState.TITLE:
                break;
            case EGameState.START:
                break;
            case EGameState.RESULT:
                break;
            case EGameState.END:
                GameQuit();
                break;
        }
    }

    public void ExitGameState(EGameState curState)
    {
        switch (curState)
        {
            case EGameState.TITLE:
                break;
            case EGameState.START:
                break;
            case EGameState.RESULT:
                break;
            case EGameState.END:
                break;
        }
    }

    public EGameState GetCurrentGameState()
    {
        return state;
    }

    private void GameQuit()
    {
        // https://fall-and-fall.hatenablog.com/entry/unity/quit-game
        // è„ãLURLéQè∆
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
      Application.Quit();
#endif
    }
}
