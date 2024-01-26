using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth : MonoBehaviour
{
    [SerializeField] private float rotetionSpeed = 0.0f;

    void Update()
    {
        transform.Rotate(0, rotetionSpeed * Time.deltaTime, 0);
    }
}
