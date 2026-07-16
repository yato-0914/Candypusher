using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    private void Start()
    {
        BGMPlay();
    }
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }else
        {
            Destroy(this.gameObject);
        }
    }
    private AudioSource audioSource;
    private AudioSource secondAudioSource;
    public AudioClip[] seAudioClips;
    public AudioClip[] bgmAudioClips;
    public AudioSource bgmAudioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void SEPlay(int i)
    {
        if (audioSource == null);
        {
            audioSource= this.gameObject.AddComponent<AudioSource>();
        }
        audioSource.clip = seAudioClips[i];
        audioSource.Play();
    }
    public void BGMPlay()
    {
        if (bgmAudioSource == null)
        {
            bgmAudioSource = this.gameObject.AddComponent<AudioSource>();
        }
        bgmAudioSource.clip = bgmAudioClips[0];
        bgmAudioSource.Play();
        bgmAudioSource.loop = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
