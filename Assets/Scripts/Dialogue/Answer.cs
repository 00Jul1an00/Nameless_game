using UnityEngine;

[System.Serializable]
public class Answer
{
    [SerializeField] private string _asnwerText;
    [SerializeField] private bool _isEndOfDialogue;
    [SerializeField] private int _nextNodeIndex;

    public int NextNodeIndex => _nextNodeIndex;
    public bool IsEndOfDialogue => _isEndOfDialogue;
    public string AnswerText => _asnwerText;
}
