using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static Drumkit;

public class DrumKit_Interaction : MonoBehaviour
{
    InputsComponent inputs = null;
    public List<Drumkit> drumKitList = null;
    DrumTypes drumType = DrumTypes.None;
    void Start()
    {
        Init();
    }

    void Init()
    {
        inputs = GetComponent<InputsComponent>();
    }

    /// <summary>
    /// Use this overload for keyboard use
    /// </summary>
    /// <param name="_drumKitElement"></param>
    public void InteractWithDrumElement(AudioSource _drumElementAudio)  // Ideally should be placed in a separate component
    {
        if (!_drumElementAudio) return;
        _drumElementAudio.Play();
    }

    DrumTypes FindDrumType()
    {
        if (drumKitList == null) return DrumTypes.None;

        int _size = drumKitList.Count;
        for (int i = 0; i < _size; i++)
        {
            switch (drumType)
            {
                case DrumTypes.HIGH:
                    InteractWithDrumElement(drumKitList[i].SoundSource);
                    break;
                case DrumTypes.MEDIUM:
                    break;
                case DrumTypes.LOW:
                    break;
                case DrumTypes.BASS:
                    break;
                case DrumTypes.CHARLESTON:
                    break;
                case DrumTypes.CRASH:
                    break;
                case DrumTypes.RIDE:
                    break;
                case DrumTypes.SNARE:
                    break;
            }
        }
        return DrumTypes.None;
    }
}