using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class addforce : MonoBehaviour
{

    public GameObject Human;
    void FixedUpdate()
    {
        Transform transform = this.GetComponent<Transform>(); //Transform���擾
        Rigidbody rb = this.GetComponent<Rigidbody>();  // rigidbody���擾
        Vector3 force = new Vector3(100f, 30f, 1500f);    // �͂�ݒ�
        rb.AddForce(force, ForceMode.Force);

        if (Human.transform.position.z <= 500)
        {
            Debug.Log("����");
        }
    }

    
}
