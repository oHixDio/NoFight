using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BlowingLevel", menuName = "ScriptableObject/Level")]
public class BlowingLevel : ScriptableObject
{
    //�X���C�_�[���~�߂����Ɍ��܂鐁����΂����x��
    public enum Level
    {
        Great = 0,
        Good,
    }
    public Level level;

    //�t���O
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
