using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyBalance : MonoBehaviour
{
    [SerializeField] private Text _text;

    private int _allMoney;

    private void Start()
    {
        _allMoney = 0;
        _text.text = _allMoney.ToString();
    }

    public void AddMoney()
    {
        _allMoney++;
        _text.text = _allMoney.ToString();
    }
}
