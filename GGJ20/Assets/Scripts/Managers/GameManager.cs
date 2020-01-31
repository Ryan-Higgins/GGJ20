using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Player data")] 
    public bool PlayerIsAlive;

    public float PlayerHealth = 100f;
    
    [Header("NPC data")] 
    public bool npcBool;

    public enum TYPE
    {
        FLYING, GROUND, DISTANCE
    }

    [Header("Game data")] 
    public int CurrentDay = 1;

    public int Currency;

    public int AmountOfFortifications;
    
    [Header("Spawn Locations")]
    public Transform Keep_Spawn; //Only one Keep 'Camp' area.
    public Transform[] Wall_Spawn; //All spawn locations for Walls
    public Transform[] Tower_Spawn; // ^
    public Transform[] Spike_Spawn; // ^ Same
    
}
