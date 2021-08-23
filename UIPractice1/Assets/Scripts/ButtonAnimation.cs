using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class ButtonAnimation : MonoBehaviour
{
    [SerializeField] private Color _targetColor;

    private Color _startColor;
    private Image _image;

    public void OnButtonClick()
    {
        _image.DOColor(Color.red, 0);
    }

    private void Awake()
    {
        _image = GetComponent<Image>();
        _startColor = _image.color;
    }

    private void OnMouseEnter()
    {
        _image.transform.DOScale(1.1f, 0.3f);
        _image.DOColor(_targetColor, 0);
    }

    private void OnMouseExit()
    {
        _image.transform.DOScale(1, 0.3f);
        _image.DOColor(_startColor, 0);
    }
}
