using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioHandler : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    public AudioSource audio_source;
    public AudioClip bgMusic;
    void Start()
    {
        audio_source.clip = bgMusic;
        audio_source.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
