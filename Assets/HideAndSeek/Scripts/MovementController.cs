using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

public class MovementController : MonoBehaviour
{
    // Controller components
    public Enemy enemy;
    public Animator animator;
    public NavMeshAgent navMeshAgent;

    // Public attributes    
    public Vector3 targetPosition;
    public Vector3 lastPosition;
    public float relativeSpeed = 0.0f;

    private float lastWalkTime = 0.0f;
    private bool targetReached = false;
    
    public bool isRunning = false;

    // Start is called before the first frame update
    public void Start()
    {
        lastPosition = transform.position;
        MoveToRandomPosition();
    }
    
    // Update is called once per frame
    public void Update()
    {
        // Apply appropriate Animation transition
        SetAnimSpeed();
        
        // Check if target has been reached
        targetReached = HasReachedTarget();
        if (targetReached && lastWalkTime + enemy.timeBetweenActions < Time.time)
        {
            MoveToRandomPosition();
        }
    }

    public void SetAnimSpeed()
    {
        if (HasReachedTarget())
        {
            relativeSpeed = 0;
        }
        else
        {
            relativeSpeed = Mathf.Lerp(navMeshAgent.speed, (transform.position - lastPosition).magnitude, 0.7f /*adjust this number in order to make interpolation quicker or slower*/);
        }
        animator.SetFloat("Speed", relativeSpeed);
        lastPosition = transform.position;
    }

    private void MoveToRandomPosition()
    {
        targetPosition = GetRandomPosition();
        MoveToTarget();
    }
    
    private void MoveToTarget()
    {
        if (isRunning)
        {
            navMeshAgent.speed = enemy.speed * enemy.runSpeedModifier;
        }
        else
        {
            navMeshAgent.speed = enemy.speed;
        }
        navMeshAgent.destination = targetPosition;
        lastWalkTime = Time.time;
    }
    
    private Vector3 GetRandomPosition()
    {
        Vector3 randomDirection = Random.insideUnitSphere * enemy.maxWalkDistance;
        randomDirection += transform.position;

        NavMesh.SamplePosition(randomDirection, out NavMeshHit hit, enemy.maxWalkDistance, 1);
        Vector3 finalPosition = hit.position;
        return finalPosition;
    }

    private bool HasReachedTarget()
    {
        return (navMeshAgent.remainingDistance == 0);
    }
}
