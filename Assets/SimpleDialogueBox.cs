using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;

using UnityEngine;

public class SimpleDialogueBox : MonoBehaviour
{
    [SerializeField]
    [TextArea]
    private List<string> _dialogueLines;
    private int _lineIndex;

    private TMP_Text _text;
    private CanvasGroup _group;
    private bool _started;

    private void Start()
    {
        Text = GetComponent<TMP_Text>();
        _group = GetComponent<CanvasGroup>();
        _group.alpha = 0;
    }

    private void OnValidate()
    {
        if(_dialogueLines.Count > 0)
        {
            if(_text == null) _text = GetComponent<TMP_Text>();
            _text.SetText(_dialogueLines[0]);
        }
    }
public TMP_Text Text { get => _text; set => _text = value; }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        { 
            if(!_started) 
            {
                _lineIndex = 0;
                Text.SetText(_dialogueLines[_lineIndex]);
                _group.alpha = 1;
                _started = true;
            
            }
                else if (_lineIndex < _dialogueLines.Count)
                {
                Text.SetText(_dialogueLines[_lineIndex++]); // uses current alue of _lineIndex adn then add 1 to it

            }

            else
            {
                _group.alpha = 0;
            }
        }
    }
}
