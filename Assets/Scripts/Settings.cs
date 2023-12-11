using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    public float audioVolume { get; private set; }

    public void SetAudioVolume(float value)
    {
        this.audioVolume = value;
    }
}
