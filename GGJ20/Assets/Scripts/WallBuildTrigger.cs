using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBuildTrigger : MonoBehaviour
{
    public GameObject tier1Wall, tier2Wall, tier3Wall;
    public GameManager _gameManager;

    [SerializeField] private int Cost;
    public bool tier1Purchased;

    private void Start()
    {
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        tier1Wall.SetActive(false);
        tier2Wall.SetActive(false);
        tier3Wall.SetActive(false);
    }


    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            // Debug.Log("Entered Wall Trigger");
            if (Input.GetKeyUp(KeyCode.E) && _gameManager.CurrentWallTier == 0)
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
                    tier1Wall.SetActive(true);
                    tier2Wall.SetActive(false);
                    tier3Wall.SetActive(false);
                    _gameManager.CurrentWallTier += 1;
                }
            }

            if (Input.GetKeyUp(KeyCode.E) && _gameManager.CurrentWallTier == 1)
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
                    tier2Wall.SetActive(true);
                    tier1Wall.SetActive(false);
                    tier3Wall.SetActive(false);
                    _gameManager.CurrentWallTier += 1;
                }
            }

            if (Input.GetKeyUp(KeyCode.E) && _gameManager.CurrentWallTier == 2)
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
                    tier3Wall.SetActive(true);
                    tier2Wall.SetActive(false);
                    tier1Wall.SetActive(false);
                    _gameManager.CurrentWallTier += 1;
                }
            }
        }
    }
}
