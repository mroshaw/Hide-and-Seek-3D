using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RhinoEnemy : Enemy
{
    // Enemy class value overrides
    public override float speed => 1.2f;
    public override float strengthModifier => 2.0f;
    public override float runSpeedModifier => 1.7f;
    public override float visionDistance => 30.0f;
    public override float visionRadius => 90.0f;
    public override float smellDistance => 90.0f;
    public override float maxWalkDistance => 20.0f;
    public override float timeBetweenActions => 20.0f;

    public override float stamina => 100.0f;
    public override float health => 100.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
