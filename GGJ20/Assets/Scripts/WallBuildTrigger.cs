using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBuildTrigger : MonoBehaviour
{
    public GameObject tier1Wall, tier2Wall, tier3Wall;
    public GameManager _gameManager;
    private void Start()
    {
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        tier1Wall.SetActive(false);
        tier2Wall.SetActive(false);
        tier3Wall.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Player entered collider.");
            if (_gameManager.CurrentWallTier == 0)
            {
                tier1Wall.SetActive(true);
            } 
            else if (_gameManager.CurrentWallTier == 1)
            {
                tier2Wall.SetActive(true);
            }
            else if (_gameManager.CurrentWallTier == 2)
            {
                tier3Wall.SetActive(true);
            } else if (_gameManager.CurrentWallTier == 3)
            {
               // tier3Wall.SetActive(true);
               Debug.Log("MAX TIER REACHED");
            }
            else
            {
                Debug.Log("No action");
            }

            /* if (_gameManager.currentWallTier == 1)
             {
                 tier1Wall.SetActive(true);
             }
             if (_gameManager.currentWallTier == 2)
             {
                 tier2Wall.SetActive(true);
             }
             if (_gameManager.currentWallTier == 3)
             {
                 tier3Wall.SetActive(true);
             }*/
        }
        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            tier1Wall.SetActive(false);
            tier2Wall.SetActive(false);
            tier3Wall.SetActive(false);
        }
    }
}
