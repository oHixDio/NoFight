using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class CutInCamera : MonoBehaviour
{
    enum EForceDirection
    {
        LEFT = 0, RIGHT = 1,
    }

    [SerializeField] private  EForceDirection dir = EForceDirection.LEFT;
    [SerializeField] private Vector3[] cameraRelativePositionList = { new Vector3(0.1f,0.05f,0.03f), new Vector3(-0.1f,0.05f,0.03f)};
    [SerializeField] private Rect[] cameraRectList = { new Rect(0,0,1,0.5f), new Rect(0,0.5f,1,0.5f)};
    [SerializeField] private float[] PitchList = { 210, 150 };
    [SerializeField] private Camera cameraObj;
    void Start()
    {

    }

    void Update()
    {
        
    }
}
