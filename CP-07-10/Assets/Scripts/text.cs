using UnityEngine;
using TMPro;

public class text : MonoBehaviour
{
    public int coins = 0;
    public TMP_Text coinText;


    void Start()
    {
        UpdateCoinText();
    }

    public void AddCoin()
    {
        coins += 1;
        UpdateCoinText();
    }

    void UpdateCoinText()
    {
        coinText.text = coins.ToString();
    }
}