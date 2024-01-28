using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class AudioTest : MonoBehaviour
{

    [SerializeField] private AudioClip sound;
    AudioSource audioS;
    // Start is called before the first frame update
    void Start()
    {
        audioS = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            audioS.PlayOneShot(sound);
        }
    }
}
