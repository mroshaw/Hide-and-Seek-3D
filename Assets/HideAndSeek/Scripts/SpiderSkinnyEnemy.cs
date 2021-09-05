using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderSkinnyEnemy : Enemy
{
    // Enemy class value overrides
    public override float speed => 2.0f;
    public override float strengthModifier => 1.1f;
    public override float runSpeedModifier => 1.7f;
    public override float visionDistance => 25.0f;
    public override float visionRadius => 90.0f;
    public override float smellDistance => 70.0f;
    public override float maxWalkDistance => 30.0f;
    public override float timeBetweenActions => 15.0f;

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
