using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeBuildTrigger : MonoBehaviour
{
    public GameObject tier1Spike, tier2Spike, tier3Spike;
    public GameManager _gameManager;
    private void Start()
    {
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        tier1Spike.SetActive(false);
        tier2Spike.SetActive(false);
        tier3Spike.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Player entered collider.");
            if (_gameManager.CurrentSpikeTier == 0)
            {
                tier1Spike.SetActive(true);
            } 
            else if (_gameManager.CurrentSpikeTier == 1)
            {
                tier2Spike.SetActive(true);
            }
            else if (_gameManager.CurrentSpikeTier == 2)
            {
                tier3Spike.SetActive(true);
            } else if (_gameManager.CurrentSpikeTier == 3)
            {
               // tier3Spike.SetActive(true);
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
            tier1Spike.SetActive(false);
            tier2Spike.SetActive(false);
            tier3Spike.SetActive(false);
        }
    }
}
