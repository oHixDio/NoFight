using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody))]
public class addforce1 : MonoBehaviour
{

    [SerializeField]
    private float m_power = 0.0f;//力の大きさ
    [SerializeField]
    private Vector3 m_powerDir = Vector3.zero;//力の方向
    [SerializeField]
    private Vector3 m_offset = Vector3.zero;//回転

    Rigidbody rb;  // rigidbodyを取得

    public GameObject Human;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.AddForceAtPosition(m_powerDir.normalized * m_power, transform.position + m_offset);
    }

    private void OnBecameInvisible()
    {

        Debug.Log("画面外");
    }
}
