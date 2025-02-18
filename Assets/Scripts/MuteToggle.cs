using UnityEngine;
using UnityEngine.UI;

public class MuteToggle : MonoBehaviour
{
    [SerializeField] private Toggle _toggle;
    [SerializeField] private AudioListener _audioListener;
    [SerializeField] private GameObject _animatedObject;

    private void OnEnable()
    {
        _toggle.onValueChanged.AddListener(Switch);
        _toggle.onValueChanged.AddListener(AnimateMuteToggle);
    }

    private void OnDisable()
    {
        _toggle.onValueChanged.RemoveListener(Switch);
        _toggle.onValueChanged.RemoveListener(AnimateMuteToggle);
    }

    private void Switch(bool isMute)
    {
        _audioListener.enabled = !isMute;
    }

    private void AnimateMuteToggle(bool isMute)
    {
        _animatedObject.SetActive(isMute);
    }
}