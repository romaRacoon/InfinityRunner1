using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private MoneyBalance _moneyBalance;
    private PlayerMovement _playerMovement;

    private void Start()
    {
        _playerMovement = GetComponent<PlayerMovement>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent<Ground>(out Ground ground))
        {
            _playerMovement.EditIsGroundedToTrue();
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.TryGetComponent<Ground>(out Ground ground))
        {
            _playerMovement.EditIsGroundedToFalse();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.TryGetComponent<Coin>(out Coin coin))
        {
            _moneyBalance.AddMoney();
        }
    }
}
