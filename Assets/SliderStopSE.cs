using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SliderStopSE : MonoBehaviour
{
    bool AudioClip = false;
    public AudioClip sound1;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            AudioClip = true;
            audioSource.PlayOneShot(sound1);
            Debug.Log("hi");
            
            
        }
        
    }
}
