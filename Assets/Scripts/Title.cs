using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Title : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    // StartButton��OnClick�ŌĂяo���B
    public void GameStart()
    {
        // �S�ē����V�[���ōs�����j�ׁ̈A�j�󂷂�݂̂̏���
        Destroy(gameObject);
        // TODO: GameManager�I�ȂƂ���̃Q�[���J�nFlag�𗧂Ă���
    }

    // EndButton��OnClick�ŌĂяo���B
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
