using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SetVolume : MonoBehaviour
{
    public AudioMixer mixer;
    private bool isTurnOn = true;

    public void SetLevel(float sliderVal)
    {
        mixer.SetFloat("Volume", Mathf.Log10(sliderVal) * 20);
    }

    public void TurnMusic()
    {
        if (isTurnOn)
        {
            SetLevel(0.01f);
            isTurnOn = false;
        }
        else
        {
            SetLevel(0.5f);
            isTurnOn = true;
        }
    }
}
