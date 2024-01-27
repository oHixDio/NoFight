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

    // StartButtonのOnClickで呼び出す。
    public void GameStart()
    {
        // 全て同じシーンで行う方針の為、破壊するのみの処理
        Destroy(gameObject);
        // TODO: GameManager的なところのゲーム開始Flagを立てたい
    }

    // EndButtonのOnClickで呼び出す。
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
