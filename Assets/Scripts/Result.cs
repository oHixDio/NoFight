using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    // backToTitleButton��OnClick�ŌĂяo��
    public void GameReset()
    {
        // ���݂̃V�[�������Z�b�g����
        SceneManager.LoadScene(0);
    }

    // EndButton��OnClick�ŌĂяo���B
    // TODO: Title�Ɠ��e���Ԃ��Ă���̂�1��
    public void GameEnd()
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
