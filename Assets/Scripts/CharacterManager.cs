using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    public GameObject characterSelectUI;
    public Player[] players;
    public void SelectCharacter(int index)
    {
        Instantiate(players[index], Vector2.zero, Quaternion.identity);
        characterSelectUI.SetActive(false);
    }
}
