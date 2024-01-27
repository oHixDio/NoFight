using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndButton : MonoBehaviour
{
    private IGameState gameState = null;
    [SerializeField] private Text btnTextObj = null;
    [SerializeField] private string btnText = "��߂�";
    private void Awake()
    {
        gameState = GameManager.instace.gameObject.GetComponent<IGameState>();
    }

    private void Start()
    {
        // ���s���ꉞ�X�V
        ChangeButtonText();
    }

    public void GameEnd()
    {
        if (gameState == null) { return; }
        gameState.ChangeGameState(EGameState.END);
        Debug.Log(gameState.GetCurrentGameState());
    }

    // �C���X�y�N�^����ύX�ł���悤�ɂ���
    [ContextMenu("ChangeText")]
    public void ChangeButtonText()
    {
        if (btnTextObj == null) { return; }
        btnTextObj.text = btnText;
    }

}
