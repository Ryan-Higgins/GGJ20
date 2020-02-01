using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepBuildTrigger : MonoBehaviour
{
    public GameObject tier1Keep, tier2Keep, tier3Keep;
    public GameManager _gameManager;
    private void Start()
    {
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        tier1Keep.SetActive(false);
        tier2Keep.SetActive(false);
        tier3Keep.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Player entered collider.");
            if (_gameManager.CurrentKeepTier == 0)
            {
                tier1Keep.SetActive(true);
            } 
            else if (_gameManager.CurrentKeepTier == 1)
            {
                tier2Keep.SetActive(true);
            }
            else if (_gameManager.CurrentKeepTier == 2)
            {
                tier3Keep.SetActive(true);
            } else if (_gameManager.CurrentKeepTier == 3)
            {
               // tier3Keep.SetActive(true);
               Debug.Log("MAX TIER REACHED");
            }
            else
            {
                Debug.Log("No action");
            }
        }
        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            tier1Keep.SetActive(false);
            tier2Keep.SetActive(false);
            tier3Keep.SetActive(false);
        }
    }
}
