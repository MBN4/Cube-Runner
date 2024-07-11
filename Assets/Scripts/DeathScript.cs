using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour
{
    public GameObject Player;
    public GameObject startPoint;

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Player"))
        {
            Player.transform.position = startPoint.transform.position;
            Debug.Log("You Died");
        }
    }
}
