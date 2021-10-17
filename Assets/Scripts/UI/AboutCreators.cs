using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AboutCreators : MonoBehaviour
{
    private Animator _animator;

    private const string _animationName = "Appearence";

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _animator.Play(_animationName);
    }

    public void Exit()
    {
        gameObject.SetActive(false);
    }
}
