using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BlowingLevel", menuName = "ScriptableObject/Level")]
public class BlowingLevel : ScriptableObject
{
    //�X���C�_�[���~�߂����Ɍ��܂鐁����΂����x��
    public enum Level
    {
        High = 0,
        Medium,
        Low,
        No
    }
    public Level level;

    //�t���O
    public bool CosmicFall_flag = false;
}
