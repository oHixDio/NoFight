using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICanvas
{
    public void SetActiveCanvas(bool active, EGameState curState);
}
