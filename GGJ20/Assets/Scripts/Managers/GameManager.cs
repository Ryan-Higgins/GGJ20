using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Player data")] 
    public bool PlayerIsAlive;
    
    [Header("NPC data")] 
    public bool npcBool;

    [Header("Game data")] 
    public int CurrentDay = 1;
    
    [Header("Spawn Locations")]
    public Transform Keep_Spawn; //Only one Keep 'Camp' area.
    public Transform[] Wall_Spawn; //All spawn locations for Walls
    public Transform[] Tower_Spawn; // ^
    public Transform[] Spike_Spawn; // ^ Same
    
}
