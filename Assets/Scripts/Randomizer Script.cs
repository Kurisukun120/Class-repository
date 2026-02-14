using TMPro;
using UnityEngine;

public class RandomizerScript : MonoBehaviour
{
   public TMP_Text numberText;
    private int randomNumber;

    public void RandomizerNumber()
    {
        randomNumber = Random.Range(0, 10);
        numberText.text = randomNumber.ToString();
    }
}                                                                                                                                        