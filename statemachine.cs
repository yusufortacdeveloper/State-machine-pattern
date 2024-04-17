using UnityEngine;

public enum CharacterState
{
    Idle,
    Running,
    Crouching,
    Attacking,
    Eating,
    Sleeping,
    Strengthening
}

public class CharacterStateMachine : MonoBehaviour
{
    private CharacterState currentState;

    private void Start()
    {
        currentState = CharacterState.Idle;
    }

    private void Update()
    {
        switch (currentState)
        {
            case CharacterState.Idle:
                break;
            case CharacterState.Running:
                break;
            case CharacterState.Crouching:
                break;
            case CharacterState.Attacking:
                break;
            case CharacterState.Eating:
                break;
            case CharacterState.Sleeping:
                break;
            case CharacterState.Strengthening:
                break;
            default:
                break;
        }
    }

    public void ChangeState(CharacterState newState)
    {
        currentState = newState;
    }
}


// yusufortacdeveloper