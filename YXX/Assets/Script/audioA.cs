using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class audioA : MonoBehaviour
{

    private AudioSource audioSource;
    public AudioClip bgm;
    public GameObject go0;
    public GameObject go1;

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
        playSound(bgm, audioSource);


    }

    public static void playSound(AudioClip clip, AudioSource audioPlayer)
    {
        audioPlayer.Stop();

        audioPlayer.clip = clip;

        audioPlayer.loop = false;

        audioPlayer.time = 0;

        audioPlayer.Play();
    }
  

    // Update is called once per frame
    void Update()
    {
        if(audioSource.isPlaying==false)
        {
            go0.SetActive(false);
            go1.SetActive(true);
        }
        else
        {
            go0.SetActive(true);
            go1.SetActive(false);
        }
    }


}
