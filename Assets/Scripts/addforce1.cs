using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody))]
public class addforce1 : MonoBehaviour
{

    [SerializeField]
    float speed = 1.0f;
    [SerializeField]
    private float m_power = 0.0f;
    [SerializeField]
    private Vector3 m_powerDir = Vector3.zero;
    [SerializeField]
    private Vector3 m_offset = Vector3.zero;

    public GameObject Human;

    void FixedUpdate()
    {
        Transform transform = this.GetComponent<Transform>(); //Transform‚ğæ“¾
        Rigidbody rb = this.GetComponent<Rigidbody>();  // rigidbody‚ğæ“¾
        rb.AddForceAtPosition(m_powerDir.normalized * m_power, transform.position + m_offset);
    }

    void calculation()
    {
        if(Human.transform.position.z == 500 )
        {
            Debug.Log("¬Œ÷");
        }
    }
}
