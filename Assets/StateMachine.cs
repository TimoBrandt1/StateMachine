using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    private States currentState;
    private Wander _wander;
    private Chase _chase;
    private enum States
    {
        WANDER,
        ATTACK,
        CHASE
    }
    // Start is called before the first frame update
    void Start()
    {
        currentState = States.WANDER;
        _wander = GetComponent<Wander>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentState)
        {
            case States.WANDER:
                _wander.CheckDestenation();
                break;
            case States.ATTACK:

                break;
            case States.CHASE:
                //_chase.ChaseTarget();
                break;
        }    
    }
    public void SetChase(Transform player)
    {
        currentState = States.CHASE;
    }
}
