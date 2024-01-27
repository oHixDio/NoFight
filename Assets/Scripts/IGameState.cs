using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGameState
{
    // ���݂̃Q�[���X�e�[�g���擾
    public EGameState GetCurrentGameState();
    // �Q�[���X�e�[�g��ύX����
    public void ChangeGameState(EGameState newState);
    // �Q�[���X�e�[�g�ɓ��������̏���
    public void EntryGameState(EGameState curState);
    // �Q�[���X�e�[�g�𔲂������̏���
    public void ExitGameState(EGameState curState);
}
