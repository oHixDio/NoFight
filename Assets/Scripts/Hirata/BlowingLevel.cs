using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BlowingLevel", menuName = "ScriptableObject/Level")]
public class BlowingLevel : ScriptableObject
{
    //スライダーを止めた時に決まる吹き飛ばすレベル
    public enum Level
    {
        Great = 0,
        Good,
    }
    public Level level;

    //フラグ
    public bool isCosmicShift = false;
    public bool CosmicFall_flag = false;

    public void CosmicShift()
    {
        isCosmicShift = true;
    }

    public void CosmicFall()
    {
        CosmicFall_flag = false;
    }
}
