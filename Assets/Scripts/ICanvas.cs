using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICanvas
{
    public void SetActiveCanvas(bool active, EGameState curState);

    public void FadeIn();

    public void FadeOut();

    public Fade GetFade();
}
