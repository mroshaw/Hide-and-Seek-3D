using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    // Enemy attributes
    public virtual float speed => 1.5f;
    public virtual float strengthModifier => 1.0f;
    public virtual float runSpeedModifier => 1.7f;
    public virtual float visionDistance => 30.0f;
    public virtual float visionRadius => 90.0f;
    public virtual float smellDistance => 90.0f;
    public virtual float maxWalkDistance => 30.0f;
    public virtual float timeBetweenActions => 20.0f;
    
    public virtual float health => 100.0f;
    public virtual float stamina => 100.0f;

    public bool isDead = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public virtual void OnDeathHandler()
    {
        isDead = true;
        MovementController movementController = GetComponent<MovementController>();
        NavMeshAgent navMeshAgent = GetComponent<NavMeshAgent>();
        navMeshAgent.enabled = false;
        movementController.animator.SetBool("IsDead", true);
        movementController.enabled = false;
    }
}
