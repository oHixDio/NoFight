using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour, ICanvas
{
    [SerializeField] private Canvas titleCanvas;
    [SerializeField] private Canvas resultCanvas;
    [SerializeField] private Canvas sliderCanvas;

    public void SetActiveCanvas(bool active, EGameState curState)
    {
        switch (curState)
        {
            case EGameState.TITLE:
                titleCanvas.gameObject.SetActive(active);
                break;
            case EGameState.START:
                break;
            case EGameState.SLIDER:
                sliderCanvas.gameObject.SetActive(active); 
                break;
            case EGameState.FLY:
                break;
            case EGameState.CUTIN:
                break;
            case EGameState.RESULT:
                resultCanvas.gameObject.SetActive(active);
                break;
            case EGameState.END:
                break;
        }
    }
}
