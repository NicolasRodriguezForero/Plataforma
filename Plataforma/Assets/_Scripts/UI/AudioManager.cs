using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public AudioSource backgroundSource;
    public AudioSource sfxSource;

    public AudioClip background;
    public AudioClip jump;
    public AudioClip coinPickup;

    public Slider backgroundMusicSlider;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void PlaySound(AudioClip clip)
    {
        sfxSource.PlayOneShot(clip);
    }

    public void PlayJump()
    {
        PlaySound(jump);
    }

    public void PlayCoin()
    {
        PlaySound(coinPickup);
    }

    public void VolumeSlider()
    {
        backgroundSource.volume = backgroundMusicSlider.value;
    }

    void Start()
    {
        backgroundMusicSlider.value = backgroundSource.volume;
    }
}
