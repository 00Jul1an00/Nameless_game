using UnityEngine;

[System.Serializable]
public class DialogueNode
{
    [SerializeField] private string _text;
    [SerializeField] private string _characterName;
     
    public Answer[] PlayerAnswers;
    public string Text => _text;
    public string CharacterName => _characterName;
}
