using UnityEngine;

public class BGMAudioManager : MonoBehaviour
{
    public AudioClip[] bgmAudioClips;
    public AudioSource bgmAudioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void BGMPlay()
    {
        bgmAudioSource.clip = bgmAudioClips[0];
        bgmAudioSource.Play();
        bgmAudioSource.loop = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
