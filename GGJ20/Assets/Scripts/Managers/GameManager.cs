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
    
    [Header("Game data")] 
    public int CurrentDay = 1;

    public int Currency;

    public int AmountOfFortifications;

    public Sprite Tier1KeepOUTLINE, Tier2KeepOUTLINE, Tier3KeepOUTLINE,
        Tier1WallOUTLINE, Tier2WallOUTLINE, Tier3WallOUTLINE,
        Tier1TowerOUTLINE, Tier2TowerOUTLINE, Tier3TowerOUTLINE,
        Tier1SpikeOUTLINE, Tier2SpikeOUTLINE, Tier3SpikeOUTLINE;
    
    [Header("Spawn Locations")]
    public Transform Keep_SpawnLOCATION; //Only one Keep 'Camp' area.
    public Transform[] Wall_SpawnLOCATION; //All spawn locations for Walls
    public Transform[] Tower_SpawnLOCATION; // ^
    public Transform[] Spike_SpawnLOCATION; // ^ Same
    
}
