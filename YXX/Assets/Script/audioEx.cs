using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class audioEx : MonoBehaviour
{


    private AudioSource audioSource;
    public AudioClip bgm;

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
        playSound(bgm, audioSource);

       
    }

    public static void playSound(AudioClip clip, AudioSource audioPlayer)
    {
        audioPlayer.Stop();

        audioPlayer.clip = clip;

        audioPlayer.loop = true;

        audioPlayer.time = 0;

        audioPlayer.Play();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
