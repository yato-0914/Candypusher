using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioSource secondAudioSource;
    public AudioClip[] seAudioClips;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void SEPlay(int i)
    {
        //ïœêîaudioSourceÇ…ñ¬ÇÁÇµÇΩÇ¢âπäy(seAudioClip)Çì¸óÕ
        audioSource.clip = seAudioClips[i];
        if (audioSource.isPlaying == false)
        {
            audioSource.Play();
        }else
        {
            secondAudioSource.clip = seAudioClips[i];
            secondAudioSource.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
