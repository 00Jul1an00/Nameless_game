using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    [SerializeField] private TMP_Text _characterNameText;
    [SerializeField] private TMP_Text _dialogueText;

    [SerializeField] private GameObject[] _buttons;
    [SerializeField] private TMP_Text[] _buttonsText;
    [SerializeField] private DialogueNode[] _nodes;

    private int _currentNodeIndex;

    private void Start()
    {
        DisableAnswerButtons();
    }

    private void DisableAnswerButtons()
    {
        foreach (var b in _buttons)
            b.gameObject.SetActive(false);
    }

    private void EnableAnswerButtons()
    {
        DisableAnswerButtons();

        for (int i = 0; i < _nodes[_currentNodeIndex].PlayerAnswers.Length; i++)
        {
            _buttons[i].gameObject.SetActive(true);
            _buttons[i].GetComponentInChildren<TMP_Text>().text = _nodes[_currentNodeIndex].PlayerAnswers[i].AnswerText;
        }
    }

    private void DisplayNextNode(int answerIndex)
    {
        if (_nodes[_currentNodeIndex].PlayerAnswers[answerIndex].IsEndOfDialogue)
        {
            _dialogueText.text = "EOD";
            DisableAnswerButtons();
            return;
        }

        _currentNodeIndex = _nodes[_currentNodeIndex].PlayerAnswers[answerIndex].NextNodeIndex;      
        StartDialog();
    }

    public void StartDialog()
    {
        _characterNameText.text = _nodes[_currentNodeIndex].CharacterName + ":";
        _dialogueText.text = _nodes[_currentNodeIndex].Text;
        EnableAnswerButtons();
    }

    public void OnClick(GameObject button)
    {
        int answerIndex = button.transform.GetSiblingIndex();
        DisplayNextNode(answerIndex);
    }
}
