using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class addforce : MonoBehaviour
{

    public GameObject Human;
    void FixedUpdate()
    {
        Transform transform = this.GetComponent<Transform>(); //Transformを取得
        Rigidbody rb = this.GetComponent<Rigidbody>();  // rigidbodyを取得
        Vector3 force = new Vector3(1,0,0);    // 力を設定
        rb.AddForce(force, ForceMode.Force)  ;

        if (Human.transform.position.z <= 500)
        {
            Debug.Log("成功");
        }
    }

    
}
