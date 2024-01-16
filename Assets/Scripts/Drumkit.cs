using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Drumkit : MonoBehaviour
{
    [SerializeField] public enum DrumTypes {
        HIGH,
        MEDIUM,
        LOW,
        BASS,
        CHARLESTON,
        CRASH,
        RIDE
    };

    public DrumTypes drumType;
    [SerializeField] AudioSource soundSource = null;

    [SerializeField] AudioClip soundToPlay = null;
    [SerializeField] AudioClip highTomsound = null;
    [SerializeField] AudioClip mediumTomSound = null;
    [SerializeField] AudioClip lowTomSound = null;
    [SerializeField] AudioClip bassSound = null;
    [SerializeField] AudioClip charlestonSound = null;
    [SerializeField] AudioClip crashSound = null;
    [SerializeField] AudioClip rideSound = null;

    void Start()
    {
        Init();
        SwitchInit();
    }
    void Init()
    {
        SetBaseSounds();
        soundSource = GetComponent<AudioSource>();
    }
    void SetBaseSounds()
    {
        //highTomsound =  Resources.Load<AudioClip>("High.wav");
        //mediumTomSound = Resources.Load<AudioClip>("Medium.wav");
        //lowTomSound = Resources.Load<AudioClip>("Low.wav");
        //highTomsound = null;
        //highTomsound = null;
        //highTomsound = null;
        //highTomsound = null;
    }

    void SwitchInit()
    {
        switch (drumType)
        {
            case DrumTypes.HIGH:
                SetSoundToPlay(highTomsound);
                break;
            case DrumTypes.MEDIUM:
                SetSoundToPlay(mediumTomSound);
                break;

            case DrumTypes.LOW:
                SetSoundToPlay(lowTomSound);
                break;

            case DrumTypes.BASS:
                SetSoundToPlay(bassSound);
                break;

            case DrumTypes.CHARLESTON:
                SetSoundToPlay(charlestonSound);
                break;

            case DrumTypes.CRASH:
                SetSoundToPlay(crashSound);
                break;
            case DrumTypes.RIDE:
                SetSoundToPlay(rideSound);
                break;

        }
    }
    // Update is called once per frame
    void Update()
    {

    }

    public void PlaySound()
    {
        soundSource.clip = soundToPlay;
        soundSource.Play();
    }

    public void SetSoundToPlay(AudioClip _soundToPlay)
    {
        soundToPlay = _soundToPlay;
    }
}
