using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBuildTrigger : MonoBehaviour
{
    public GameObject tier1Tower, tier2Tower, tier3Tower;
    public GameManager _gameManager;
    private void Start()
    {
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        tier1Tower.SetActive(false);
        tier2Tower.SetActive(false);
        tier3Tower.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Player entered collider.");
            if (_gameManager.CurrentTowerTier == 0)
            {
                tier1Tower.SetActive(true);
            } 
            else if (_gameManager.CurrentTowerTier == 1)
            {
                tier2Tower.SetActive(true);
            }
            else if (_gameManager.CurrentTowerTier == 2)
            {
                tier3Tower.SetActive(true);
            } else if (_gameManager.CurrentTowerTier == 3)
            {
               // tier3Tower.SetActive(true);
               Debug.Log("MAX TIER REACHED");
            }
            else
            {
                Debug.Log("No action");
            }

            /* if (_gameManager.currentTowerTier == 1)
             {
                 tier1Tower.SetActive(true);
             }
             if (_gameManager.currentTowerTier == 2)
             {
                 tier2Tower.SetActive(true);
             }
             if (_gameManager.currentTowerTier == 3)
             {
                 tier3Tower.SetActive(true);
             }*/
        }
        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            tier1Tower.SetActive(false);
            tier2Tower.SetActive(false);
            tier3Tower.SetActive(false);
        }
    }
}
