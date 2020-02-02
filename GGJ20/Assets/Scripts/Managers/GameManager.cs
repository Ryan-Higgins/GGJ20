using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Player data")]
    public bool PlayerIsAlive;

    public static float PlayerHealth = 100f;

    [Header("NPC data")]
    public bool npcBool;

    public int currentWave = 1;
    
    [Header("Game data")]
    public static int CurrentDay = 1;

    public float TimeOfDay = 0;
    
    /*
     * Will need to make 2 of each for left and right of the map as currently they share the same value.
     * ??
     */
    public int CurrentTowerTier = 1;
    public int CurrentKeepTier = 1;
    public int CurrentSpikeTier = 1;
    public int CurrentWallTier = 1;

    public int Currency;

    public int AmountOfFortifications;

    /*
    public GameObject
        Tier1KeepOUTLINE, Tier2KeepOUTLINE, Tier3KeepOUTLINE,
        Tier1WallOUTLINE, Tier2WallOUTLINE, Tier3WallOUTLINE,
        Tier1TowerOUTLINE, Tier2TowerOUTLINE, Tier3TowerOUTLINE,
        Tier1SpikeOUTLINE, Tier2SpikeOUTLINE, Tier3SpikeOUTLINE;
        
    [Header("Spawn Locations")]
    public Transform Keep_SpawnLOCATION; //Only one Keep 'Camp' area.
    public Transform[] Wall_SpawnLOCATION; //All spawn locations for Walls
    public Transform[] Tower_SpawnLOCATION; // ^
    public Transform[] Spike_SpawnLOCATION; // ^ Same
*/
    [SerializeField] private GameObject NightSky;

    public void Update()
    {
        TimeOfDay += 1 * Time.deltaTime;

        if (TimeOfDay < 60)
        {
            Color tempColor = NightSky.GetComponent<SpriteRenderer>().color;
            tempColor.a = tempColor.a  + 1 * Time.deltaTime / 100;
            NightSky.GetComponent<SpriteRenderer>().color = tempColor;
        } else if (TimeOfDay > 60 && TimeOfDay < 120)
        {
            Color tempColor = NightSky.GetComponent<SpriteRenderer>().color;
            tempColor.a = tempColor.a - 1 * Time.deltaTime / 100;
            NightSky.GetComponent<SpriteRenderer>().color = tempColor;
        }
        //print(TimeOfDay);

        if (TimeOfDay > 120)
        {
            CurrentDay++;
            TimeOfDay = 0;
        }
    }
}
