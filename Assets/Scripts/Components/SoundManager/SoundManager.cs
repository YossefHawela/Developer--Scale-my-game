using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    public AudioClip ClickClackSound;

    private void Awake()
    {
        Instance= this;
    }

    public void CreateAudioSource(AudioClip clip)
    {
        GameObject go = new GameObject();

        AudioSource Ac=  go.AddComponent<AudioSource>();
        Ac.clip = clip;

        Ac.Play();

        Destroy(go, clip.length);


    }
}
