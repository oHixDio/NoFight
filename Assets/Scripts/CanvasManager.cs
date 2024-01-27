using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour, ICanvas
{
    [SerializeField] private Canvas titleCanvas;
    [SerializeField] private Canvas resultCanvas;

    public void SetActiveCanvas(bool active, EGameState curState)
    {
        switch (curState)
        {
            case EGameState.TITLE:
                titleCanvas.gameObject.SetActive(active);
                break;
            case EGameState.START:
                break;
            case EGameState.RESULT:
                resultCanvas.gameObject.SetActive(active);
                break;
            case EGameState.END:
                break;
        }
    }
}
