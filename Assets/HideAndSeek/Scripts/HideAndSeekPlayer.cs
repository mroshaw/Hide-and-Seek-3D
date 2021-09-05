using System;
using System.Collections;
using System.Collections.Generic;using Gaia;
using Invector.vCharacterController;
using UnityEngine;


public class HideAndSeekPlayer : MonoBehaviour
{
    public bool hasFoundTreasure = false;
    public vHUDController vHud;
    public AudioSource audioSource;
    public AudioClip playerDamagedClip;
    public AudioClip playerDeadClip;
    
    // Start is called before the first frame update
    void Start()
    {
        vHud.ShowText("Find the treasure and return to base!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        
        // If I've found the treasure
        if (other.gameObject.name == "Treasure")
        {
            hasFoundTreasure = true;
            vHud.ShowText("Treasure found! Now get back home!");
            Destroy(other.gameObject);
        }
        // If I'm trying to return home
        if (other.gameObject.name == "Home" && !hasFoundTreasure)
        {
            // Still need to find the treasure!
            vHud.ShowText("You haven't found the treasure yet!");
        }

        if (other.gameObject.name == "Home" && hasFoundTreasure)
        {
            // You win!!!
            vHud.ShowText("Treasure returned! YOU WIN!");
        }
    }

    public void PlayerDamaged()
    {
        audioSource.PlayOneShot(playerDamagedClip);
    }

    public void PlayerDead()
    {
        audioSource.PlayOneShot(playerDeadClip);

    }
}
