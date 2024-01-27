using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slidermove : MonoBehaviour
{
    [SerializeField] Slider Slider;
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
            }
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

        if (maxValue == true)
        {
            Slider.value -= 0.1f;
        }

        if (maxValue == false)
        {
            Slider.value += 0.1f;
        }
    }
}