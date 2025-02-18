using UnityEngine;
using UnityEngine.UI;

public class ButtonEffect : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private AudioSource _clip;

    private void OnEnable()
    {
        _button.onClick.AddListener(ButtonEffectClick);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(ButtonEffectClick);
    }

    private void ButtonEffectClick()
    {
        _clip.Play();
    }
}