using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndButton : MonoBehaviour
{
    private IGameState gameState = null;
    [SerializeField] private Text btnTextObj = null;
    [SerializeField] private string btnText = "やめる";
    private void Awake()
    {
        gameState = GameManager.instace.gameObject.GetComponent<IGameState>();
    }

    private void Start()
    {
        // 実行時一応更新
        ChangeButtonText();
    }

    public void GameEnd()
    {
        if (gameState == null) { return; }
        gameState.ChangeGameState(EGameState.END);
        Debug.Log(gameState.GetCurrentGameState());
    }

    // インスペクタから変更できるようにする
    [ContextMenu("ChangeText")]
    public void ChangeButtonText()
    {
        if (btnTextObj == null) { return; }
        btnTextObj.text = btnText;
    }

}
