using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGameState
{
    // 現在のゲームステートを取得
    public EGameState GetCurrentGameState();
    // ゲームステートを変更する
    public void ChangeGameState(EGameState newState);
    // ゲームステートに入った時の処理
    public void EntryGameState(EGameState curState);
    // ゲームステートを抜けた時の処理
    public void ExitGameState(EGameState curState);
}
