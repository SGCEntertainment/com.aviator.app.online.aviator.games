using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{
    public static Counter instance;

    [HideInInspector] public int count = 0;
    private int coin = 0;

    [SerializeField] private TextMeshProUGUI counterText;
    [SerializeField] private TextMeshProUGUI coinText;

    private void Start()
    {
        instance = this;
        counterText.text = count.ToString();
    }

    public void Plus()
    {
        if (count < 5)
        {
            count++;
        }

        counterText.text = count.ToString();
    }

    public void Minus()
    {
        if (count > 0)
        {
            count--;
        }

        counterText.text= count.ToString();
    }

    public void AddCoin(int count)
    {
        coin += count;
        coinText.text = coin.ToString();
    }
}
