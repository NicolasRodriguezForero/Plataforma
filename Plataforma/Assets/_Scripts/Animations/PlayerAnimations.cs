using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    private Animator _animator;
    private NewInput _newInput;
    private SpriteRenderer _sprite;

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        _newInput = GetComponent<NewInput>();
        _sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        MovementAnim();
    }

    public void MovementAnim()
    {
        if(_newInput.inputX != 0)
        {
            _animator.SetBool("Walk", true);
        }
        else
        {
            _animator.SetBool("Walk", false);
        }

        // // Voltear sprite según dirección
        // if (_newInput.inputX < 0)
        // {
        //     _sprite.flipX = true;
        // }
        // else if (_newInput.inputX > 0)
        // {
        //     _sprite.flipX = false;
        // }
    }
}
