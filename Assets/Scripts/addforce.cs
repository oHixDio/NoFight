using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
