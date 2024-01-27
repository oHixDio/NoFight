using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BlowingLevel", menuName = "ScriptableObject/Level")]
public class BlowingLevel : ScriptableObject
{
    //スライダーを止めた時に決まる吹き飛ばすレベル
    public enum Level
    {
        High = 0,
        Medium,
        Low,
        No
    }
    public Level level;

    //フラグ
    public bool CosmicFall_flag = false;
}
