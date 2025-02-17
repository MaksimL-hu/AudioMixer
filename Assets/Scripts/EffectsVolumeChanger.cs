using UnityEngine;

public class EffectsVolumeChanger : MonoBehaviour
{
    [SerializeField] private VolumeChanger _volumeChanger;

    public void ChangeEffectVolume(float value)
    {
        _volumeChanger.ChangeVolume(VolumeChanger.EffectVolume, value);
    }
}