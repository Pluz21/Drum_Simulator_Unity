using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drumkit : MonoBehaviour
{
    [SerializeField] public enum DrumType {
        HIGH,
        MEDIUM,
        LOW,
        BASS,
        CHARLESTON,
        CRASH,
        RIDE
    };

    public DrumType drumtype;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlaySound()
    {

    }
}
