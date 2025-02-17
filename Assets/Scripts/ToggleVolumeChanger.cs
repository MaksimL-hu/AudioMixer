using UnityEngine;

public class ToggleVolumeChanger : MonoBehaviour
{
    [SerializeField] private VolumeChanger _volumeChanger;

    public void Switch(bool isMute)
    {
        if (isMute)
            _volumeChanger.ChangeMasterVolume(VolumeChanger.ZeroVolume);
        else
            _volumeChanger.ChangeMasterVolume(VolumeChanger.NormalVolume);
    }
}