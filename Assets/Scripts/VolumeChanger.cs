using UnityEngine;
using UnityEngine.Audio;

public class VolumeChanger : MonoBehaviour
{
    public const float ZeroVolume = 0.001f;
    public const float NormalVolume = 1f;
    public const string MasterVolume = nameof(MasterVolume);
    public const string EffectVolume = nameof(EffectVolume);
    public const string MusicVolume = nameof(MusicVolume);

    [SerializeField] private AudioMixerGroup _audioMixer;
    
    public void ChangeMasterVolume(float value)
    {
        ChangeVolume(MasterVolume, value);
    }

    public void ChangeVolume(string name, float volume)
    {
        _audioMixer.audioMixer.SetFloat(name, Mathf.Log10(volume) * 20);
    }
}