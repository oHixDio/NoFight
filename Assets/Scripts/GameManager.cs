using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour, IGameState
{
    // �V���O���g���ϐ�
    public static GameManager instace;
    private EGameState state = EGameState.TITLE;
    [SerializeField] private GameObject canvasManager = null;
    private ICanvas canvas = null;

    void Awake()
    {
        // ���g���擾
        if (instace == null)
        {
            instace = this;
        }
        // FPS 60�ɐݒ�
        Application.targetFrameRate = 60;
        // �����X�e�[�g��Title�ɐݒ�
        state = EGameState.TITLE;
        canvas = canvasManager.gameObject.GetComponent<ICanvas>();
    }

    void Start()
    {
        EntryGameState(state);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ChangeGameState(EGameState.RESULT);
        }
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
                canvas.SetActiveCanvas(true, state);
                break;
            case EGameState.START:
                Debug.Log("Start");
                break;

            case EGameState.SLIDER:

                break;
            case EGameState.FLY:

                break;
            case EGameState.CUTIN:

                break;

            case EGameState.RESULT:
                canvas.SetActiveCanvas(true, state);
                break;
            case EGameState.END:
                GameQuit();
                break;
            case EGameState.RESTART:
                SceneManager.LoadScene(0);
                break;
        }
    }

    public void ExitGameState(EGameState curState)
    {
        switch (curState)
        {
            case EGameState.TITLE:
                canvas.SetActiveCanvas(false, state);
                break;
            case EGameState.START:
                break;
            case EGameState.RESULT:
                canvas.SetActiveCanvas(false, state);
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
        // ��LURL�Q��
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
      Application.Quit();
#endif
    }
}
