using UnityEngine;

public class MusicVolumeChanger : MonoBehaviour
{
    [SerializeField] private VolumeChanger _volumeChanger;

    public void ChangeMusicVolume(float value)
    {
        _volumeChanger.ChangeVolume(VolumeChanger.MusicVolume, value);
    }
}