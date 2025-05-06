using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallColiision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
            gameManager.GameOver();
        }
    }
}
