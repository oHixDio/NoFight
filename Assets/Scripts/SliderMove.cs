using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slidermove : MonoBehaviour
{
    private IGameState gameState = null;
    [SerializeField] float BarSpeed = 1f;
    [SerializeField] Slider Slider;
    [SerializeField] private float nextStateTime = 5f;

    public float FlyingDistance;
    private bool isClicked;

    // Start is called before the first frame update
    void Start()
    {
        gameState = GameManager.instace.GetComponent<IGameState>();
        Slider.value = 0;
        isClicked = false;
    }

    // Update is called once per frame
    void Update()
    {
        //一度クリックしたらここの処理は使わないからリターンする
        if (isClicked)
        {
            return;
        }
        if (Input.GetMouseButtonDown(0) && isClicked == false)
        {
            SliderStop();
        }

        //ここでスライダーの数値を変更しています
        if (Slider.value == 10 || Slider.value ==0)
        {
            BarSpeed *= -1;  
        }
        //ここからバーの速さ
        Slider.value += BarSpeed * Time.deltaTime;
    }
    private void SliderStop()
    {
        //ステートの変更をしています
        isClicked = true;
        Invoke("callState", nextStateTime);


        //リザルトの値をここで決めています
        if (Slider.value >= 4.5 && Slider.value <= 5.5)
        {
            FlyingDistance = 10;
        }

        else if (Slider.value >= 2.0 && Slider.value <= 4.5 || Slider.value >= 5.5 && Slider.value <= 8.0)
        {
            FlyingDistance = 5;
        }

        else if (Slider.value >= 0.0 && Slider.value <= 2.0 || Slider.value >= 8.0 && Slider.value <= 10.0)

        {
            FlyingDistance = 1;
        };

    }
    private void callState()
    {
        gameState.ChangeGameState(EGameState.FLY);
    }
}