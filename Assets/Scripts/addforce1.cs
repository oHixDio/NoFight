using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody))]
public class addforce1 : MonoBehaviour
{

    [SerializeField]
    private float m_power = 0.0f;//�͂̑傫��
    [SerializeField]
    private Vector3 m_powerDir = Vector3.zero;//�͂̕���
    [SerializeField]
    private Vector3 m_offset = Vector3.zero;//��]

    Rigidbody rb;  // rigidbody���擾

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

        Debug.Log("��ʊO");
    }
}
