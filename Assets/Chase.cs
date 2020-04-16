using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Chase : MonoBehaviour
{
    private Collider detector;
    public playerDetection _playerDetection;
    private NavMeshAgent myAgent;
    public GameObject target;
    public StateMachine _stateMachine;

    // Start is called before the first frame update
    void Start()
    {
        detector = GetComponentInChildren<Collider>();
        _playerDetection.onPlayerDetection += ChaseTarget;
        myAgent = GetComponent<NavMeshAgent>();
        _playerDetection.onPlayerDetection += _stateMachine.SetChase;
    }

    // Update is called once per frame
    void Update()
    {
        // myAgent.SetDestination(target.transform.position);
    }

    private void ChaseTarget(Transform Player)
    {
        myAgent.SetDestination(Player.position);
    }
}
