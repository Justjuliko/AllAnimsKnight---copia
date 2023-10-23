using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    private enum PlayerState
    {
        Idle,
        IdleBreaker,
        Walk,
        Run,
        Jump,
        Attack
    }
    private bool IsWalking()
    {
        return Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.LeftShift);
    }
    private bool IsRunning()
    {
        return Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift);
    }
    private bool Jumping()
    {
        return Input.GetKey(KeyCode.Space);
    }
    private bool Attacking()
    {
        return Input.GetKey(KeyCode.Mouse0);
    }
    public Animator _CharacterAnimator;
    private PlayerState _currentState;
    void Start()
    {
        SetState(PlayerState.Idle);
    }
    void Update()
    {
        PlayerState newState = DeterminateState();
        if(newState != _currentState )
        {
            SetState(newState);
        }
    }
    private void SetState(PlayerState newState)
    {
        switch (_currentState) 
        {
        case PlayerState.Idle:
                _CharacterAnimator.SetBool("idle", false); break;
        case PlayerState.IdleBreaker:
                _CharacterAnimator.SetBool("idleBreaker", false); break;
        case PlayerState.Walk:
                _CharacterAnimator.SetBool("walk", false); break;
        case PlayerState.Run:
                _CharacterAnimator.SetBool("run", false); break;
        case PlayerState.Jump:
                _CharacterAnimator.SetBool("jump", false); break;
        case PlayerState.Attack:
                _CharacterAnimator.SetBool("attack", false); break;
        }
        switch (newState)
        {
        case PlayerState.Idle:
            _CharacterAnimator.SetBool("idle", true); break;
        case PlayerState.IdleBreaker:
            _CharacterAnimator.SetBool("idleBreaker", true); break;
        case PlayerState.Walk:
            _CharacterAnimator.SetBool("walk", true); break;
        case PlayerState.Run:
            _CharacterAnimator.SetBool("run", true); break;
        case PlayerState.Jump:
            _CharacterAnimator.SetBool("jump", true); break;
        case PlayerState.Attack:
            _CharacterAnimator.SetBool("attack", true); break;
        }
        _currentState = newState;
    }
    private PlayerState DeterminateState()
    {
        if(Input.GetKeyDown(KeyCode.Y))
        {
            return PlayerState.IdleBreaker;
        }
        else if(IsRunning())
        {
            return PlayerState.Run;
        }
        else if(IsWalking())
        {
            return PlayerState.Walk;
        }
        else if(Jumping())
        {
            return PlayerState.Jump;
        }
        else if(Attacking())
        {
            return PlayerState.Attack;
        }
        else
        { 
        return PlayerState.Idle; 
        }
    }
}
