using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class TextHackAnimation : MonoBehaviour
{
    private Text _text;

    void Start()
    {
        _text = GetComponent<Text>();
        _text.DOText(_text.text, _text.text.Length / 2f, true, ScrambleMode.All);
    }
}
