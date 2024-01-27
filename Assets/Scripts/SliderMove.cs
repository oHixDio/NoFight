using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slidermove : MonoBehaviour
{
    [SerializeField] float BarSpeed;
    [SerializeField] Slider Slider;
    public float FlyingDistance;
    private bool isClicked;
    private bool maxValue;

    // Start is called before the first frame update
    void Start()
    {
        Slider.value = 0;
        maxValue = false;
        isClicked = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && isClicked == false)
        {
            Debug.Log("stop");
            isClicked = true;
        }
        else if (Input.GetMouseButtonDown(0) && isClicked == true)
        {
            Debug.Log("start");
            isClicked = false;
        }
        if (isClicked)
        {
             if (Slider.value >= 4.5 && Slider.value <= 5.5)
                {
                    Debug.Log("Great!!");
                FlyingDistance = 10;
                }

        else if (Slider.value >= 2.0 && Slider.value <= 4.5 || Slider.value >= 5.5 && Slider.value <= 8.0)
                {
                    Debug.Log("Good");
                    FlyingDistance = 5;
                }

        else if(Slider.value >= 0.0 && Slider.value <= 2.0 || Slider.value >= 8.0 && Slider.value <= 10.0)
            
                {
                    Debug.Log("Bad!!");
                    FlyingDistance = 1;
                };
                
                

            return;
        }

       

        if (Slider.value == 10)
        {
            maxValue = true;
        }
        if (Slider.value == 0)
        {
            maxValue = false;
        }

        //‚±‚±‚©‚çƒo[‚Ì‘¬‚³
        if (maxValue == true)
        {
            Slider.value -= BarSpeed * Time.deltaTime;
        }

        if (maxValue == false)
        {
            Slider.value += BarSpeed * Time.deltaTime;
        }
    }
}