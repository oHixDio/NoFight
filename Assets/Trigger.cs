using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //�����������̏���
    void OnTriggerEnter(Collider collider)
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        Vector3 force = new Vector3(0, 20, 0);
        //���������I�u�W�F�N�g������
        rb.AddForce(force);

    } 
}
