using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBuildTrigger : MonoBehaviour
{
    public GameObject tier1Tower, tier2Tower, tier3Tower;
    public GameManager _gameManager;

    public int Cost = 1;
    //public bool Purchased;
    private void Start()
    {
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        tier1Tower.SetActive(false);
        tier2Tower.SetActive(false);
        tier3Tower.SetActive(false);
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
           // Debug.Log("Entered Tower Trigger");
            if (Input.GetKeyUp(KeyCode.E) && _gameManager.CurrentTowerTier == 0)
            {
              //  Debug.Log("Key pressed within trigger.");
                if (_gameManager.Currency <= Cost)
                {
                    Debug.Log("No Money.");
                }

                if (_gameManager.Currency >= Cost)
                {
                    Debug.Log(("Purchased Wall!"));
                    _gameManager.Currency = _gameManager.Currency - Cost;
                    tier1Tower.SetActive(true);
                    tier2Tower.SetActive(false);
                    tier3Tower.SetActive(false);
                    _gameManager.CurrentTowerTier += 1;
                } 
            }
            
            if (Input.GetKeyUp(KeyCode.E) && _gameManager.CurrentTowerTier == 1)
            {
                Debug.Log("Key pressed within trigger.");
                if (_gameManager.Currency <= Cost)
                {
                    Debug.Log("No Money.");
                }

                if (_gameManager.Currency >= Cost)
                {
                    Debug.Log(("Purchased Wall!"));
                    _gameManager.Currency = _gameManager.Currency - Cost;
                    tier2Tower.SetActive(true);
                    tier1Tower.SetActive(false);
                    tier3Tower.SetActive(false);
                    _gameManager.CurrentTowerTier += 1;
                } 
            }
            
            if (Input.GetKeyUp(KeyCode.E) && _gameManager.CurrentTowerTier == 2)
            {
                Debug.Log("Key pressed within trigger.");
                if (_gameManager.Currency <= Cost)
                {
                    Debug.Log("No Money.");
                }

                if (_gameManager.Currency >= Cost)
                {
                    Debug.Log(("Purchased Wall!"));
                    _gameManager.Currency = _gameManager.Currency - Cost;
                    tier3Tower.SetActive(true);
                    tier2Tower.SetActive(false);
                    tier1Tower.SetActive(false);
                    _gameManager.CurrentTowerTier += 1;
                } 
            }
            
            /*
            Debug.Log("Player entered Tower Trigger.");
            if (Input.GetKeyDown(KeyCode.E) && _gameManager.CurrentTowerTier == 0)
            {
              //  if ( _gameManager.Currency >= Cost)
              //  {
                    tier1Tower.SetActive(true);
                //    _gameManager.Currency = _gameManager.Currency - Cost;
                    Purchased = true;
               // }
            } 
            else if (Input.GetKeyDown(KeyCode.E) && _gameManager.CurrentTowerTier == 1)
            {
                //  if ( _gameManager.Currency >= Cost)
                //  {
                tier2Tower.SetActive(true);
                //    _gameManager.Currency = _gameManager.Currency - Cost;
                Purchased = true;
                // }
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
        }*/
        
    }

    /*private void OnTriggerExit2D(Collider2D other)
    {
        if (Purchased)
        {
            tier1Tower.SetActive(true);
        }
        if (other.tag == "Player")
        {
            tier1Tower.SetActive(false);
            tier2Tower.SetActive(false);
            tier3Tower.SetActive(false);
        }*/
    }
}
