using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour, IGameState
{
    // シングルトン変数
    public static GameManager instace;
    private EGameState state = EGameState.TITLE;
    [SerializeField] private GameObject canvasManager = null;
    private ICanvas canvas = null;

    [SerializeField] private GameObject mainCam = null;

    [SerializeField] private GameObject cosmicViewScene;
    [SerializeField] private GameObject cosmicBeforeScene;

    [SerializeField] private BlowingLevel blowingLevel;

    public float Result;

    void Awake()
    {
        // 自身を取得
        if (instace == null)
        {
            instace = this;
        }
        // FPS 60に設定
        Application.targetFrameRate = 60;
        // 初期ステートをTitleに設定
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
                canvas.SetActiveCanvas(true, state);
                break;
            case EGameState.FLY:
                break;
            case EGameState.CUTIN:
                CutInMode();
                break;
            case EGameState.COSMIC:
                Debug.Log("Cosmic");
                cosmicViewScene.SetActive(true);
                cosmicBeforeScene.SetActive(false);
                canvas.FadeIn();
                Invoke("CosmicShiftMode", canvas.GetFade().FadeTime);
                break;
            case EGameState.RESULT:
                // canvas.SetActiveCanvas(true, state);
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
            case EGameState.SLIDER:
                canvas.SetActiveCanvas(false, state);
                break;
            case EGameState.FLY:
               
                break;
            case EGameState.CUTIN:
               
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
        // 上記URL参照
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
      Application.Quit();
#endif
    }

    public void CutInMode()
    {
        mainCam.SetActive(false);
    }

    public void CosmicShiftMode()
    {
        blowingLevel.isCosmicShift = true;
    }
}
