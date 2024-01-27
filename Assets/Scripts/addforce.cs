using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD


[RequireComponent(typeof(Rigidbody))]
public class addforce : MonoBehaviour
{
    [SerializeField]
    private float m_power = 0.0f;
    [SerializeField]
    private Vector3 m_powerDir = Vector3.zero;
    [SerializeField]
    private Vector3 m_offset = Vector3.zero;

    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.AddForceAtPosition(m_powerDir.normalized * m_power, transform.position + m_offset);
    }

    void OnBecameInvisible()
    {
        Debug.Log("‰æ–ÊŠO");
    }
}

=======
using UnityEngine.UI;

public class addforce : MonoBehaviour
{

    public GameObject Human;
    void FixedUpdate()
    {
        Transform transform = this.GetComponent<Transform>(); //Transform‚ğæ“¾
        Rigidbody rb = this.GetComponent<Rigidbody>();  // rigidbody‚ğæ“¾
        Vector3 force = new Vector3(1,0,0);    // —Í‚ğİ’è
        rb.AddForce(force, ForceMode.Force)  ;

        if (Human.transform.position.z <= 500)
        {
            Debug.Log("¬Œ÷");
        }
    }

    
}
>>>>>>> 43cbe87a1da176080bdb591826c0eb9f9ed61044
