using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public GameObject endParticle;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Lava"))
        {
            Debug.Log("Gameover");
            Application.LoadLevel(Application.loadedLevel);
        }

        if (other.CompareTag("Finish"))
        {

            Instantiate(endParticle , transform.position , Quaternion.identity);
            Invoke("ResetGame", 5f);
        }
    }

    private void ResetGame()
    {
        Application.LoadLevel(Application.loadedLevel);
    }


}
