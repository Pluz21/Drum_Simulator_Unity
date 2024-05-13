using UnityEngine;
using UnityEngine.InputSystem;
using static Drumkit;

public class DrumKitController : MonoBehaviour
{
    [SerializeField] public AudioSource bassSoundSource = null;
    [SerializeField] public AudioSource highTomSoundSource = null;
    [SerializeField] public AudioSource mediumTomSoundSource = null;
    [SerializeField] public AudioSource lowTomSoundSource = null;
    [SerializeField] public AudioSource snareSoundSource = null;
    [SerializeField] public AudioSource charlestonSoundSource = null;
    [SerializeField] public AudioSource crashSoundSource = null;
    [SerializeField] public AudioSource rideSoundSource = null;


    void Start()
    {
        Init();
    }

    void Init()
    {
        InputsComponent inputs = GetComponent<InputsComponent>();

        //bassSoundSource = GetComponent<AudioSource>();
        //highTomSoundSource = GetComponent<AudioSource>();
        //mediumTomSoundSource = GetComponent<AudioSource>();
        //lowTomSoundSource = GetComponent<AudioSource>();
        //snareSoundSource = GetComponent<AudioSource>();
        //charlestonSoundSource = GetComponent<AudioSource>();
        //crashSoundSource = GetComponent<AudioSource>();
        //rideSoundSource = GetComponent<AudioSource>();

        inputs.Bass.performed += InteractWithBass;
        inputs.HighTom.performed += InteractWithHighTom;
        inputs.MediumTom.performed += InteractWithMediumTom;
        inputs.LowTom.performed += InteractWithLowTom;
        inputs.Snare.performed += InteractWithSnare;
        inputs.Charleston.performed += InteractWithCharleston;
        inputs.Crash.performed += InteractWithCrash;
        inputs.Ride.performed += InteractWithRide;
    }

    public void InteractWithBass(InputAction.CallbackContext context)
    {
        if (!bassSoundSource) return;
        bassSoundSource.Play();
        Debug.Log("pressed bass input");
    }

    public void InteractWithHighTom(InputAction.CallbackContext context)
    {
        if (!highTomSoundSource) return;
        highTomSoundSource.Play();
    }

    public void InteractWithMediumTom(InputAction.CallbackContext context)
    {
        if (!mediumTomSoundSource) return;
        mediumTomSoundSource.Play();
    }

    public void InteractWithLowTom(InputAction.CallbackContext context)
    {
        if (!lowTomSoundSource) return;
        lowTomSoundSource.Play();
    }

    public void InteractWithSnare(InputAction.CallbackContext context)
    {
        if (!snareSoundSource) return;
        snareSoundSource.Play();
    }

    public void InteractWithCharleston(InputAction.CallbackContext context)
    {
        if (!charlestonSoundSource) return;
        charlestonSoundSource.Play();
    }

    public void InteractWithCrash(InputAction.CallbackContext context)
    {
        if (!crashSoundSource) return;
        crashSoundSource.Play();
    }

    public void InteractWithRide(InputAction.CallbackContext context)
    {
        if (!rideSoundSource) return;
        rideSoundSource.Play();
    }

    // Implement similar methods for other drum types if needed
}
