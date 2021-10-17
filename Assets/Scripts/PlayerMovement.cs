using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;

    private bool _isGrounded = true;
    private Rigidbody _rigidbody;
    private Transform _transform;

    private const string _horizontal = "Horizontal";
    private const string _jump = "Jump";

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _transform = GetComponent<Transform>();
    }


    void FixedUpdate()
    {
        Jump();
        MoveForward();
        MoveHorizontal();
    }

    private void MoveHorizontal()
    {
        float horizontalCoordinate = Input.GetAxis(_horizontal);
        Vector3 directionMovement = new Vector3(horizontalCoordinate, 0, 0);
        _transform.Translate(directionMovement * _speed * Time.fixedDeltaTime);
    }

    private void MoveForward()
    {
        float verticalCoordinate = 1f;
        Vector3 directionMovement = new Vector3(0, 0, verticalCoordinate);
        _transform.Translate(directionMovement * _speed * Time.fixedDeltaTime);
    }

    private void Jump()
    {
        if (Input.GetAxis(_jump) > 0)
        {
            if (_isGrounded)
            {
                _rigidbody.AddForce(Vector3.up * _jumpForce);
            }
        }
    }

    public void EditIsGroundedToFalse()
    {
        _isGrounded = false;
    }

    public void EditIsGroundedToTrue()
    {
        _isGrounded = true;
    }
}
