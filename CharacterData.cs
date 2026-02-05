using UnityEngine;

[CreateAssetMenu(menuName = "Game/Character")]
public class CharacterData : ScriptableObject
{
    public string characterName;
    public ItemData correctItem;
}