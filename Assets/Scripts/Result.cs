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

    // backToTitleButtonのOnClickで呼び出し
    public void GameReset()
    {
        // 現在のシーンをリセットする
        SceneManager.LoadScene(0);
    }

    // EndButtonのOnClickで呼び出す。
    // TODO: Titleと内容かぶっているのを1つに
    public void GameEnd()
    {
        // https://fall-and-fall.hatenablog.com/entry/unity/quit-game
        // 上記URL参照
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
      Application.Quit();
#endif
    }
}
