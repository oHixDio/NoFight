using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour, ICanvas
{
    [SerializeField] private Canvas titleCanvas;
    [SerializeField] private Canvas resultCanvas;
    [SerializeField] private Canvas sliderCanvas;
    [SerializeField] private Canvas fadeCanvas;

    public void SetActiveCanvas(bool active, EGameState curState)
    {
        switch (curState)
        {
            case EGameState.TITLE:
                fadeCanvas.GetComponentInChildren<Fade>().FadeIn();
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
            case EGameState.COSMIC:
                break;
            case EGameState.RESULT:
                resultCanvas.gameObject.SetActive(active);
                break;
            case EGameState.END:
                break;
        }
    }

   public void FadeIn()
    {
        Fade fade = fadeCanvas.GetComponentInChildren<Fade>();
        fade.FadeIn();
    }

    public void FadeOut()
    {
        Fade fade = fadeCanvas.GetComponentInChildren<Fade>();
        fade.FadeOut();
    }

    public Fade GetFade()
    {
        return fadeCanvas.GetComponentInChildren<Fade>();
    }
}
