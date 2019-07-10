using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerClick : MonoBehaviour
{
    private void OnMouseDrag()
    {
        PlayerManager.Instance.player.GetComponent<trajectoryScript>().readyToJump();
    }

    private void OnMouseUp()
    {
        PlayerManager.Instance.player.GetComponent<trajectoryScript>().jumpNow();
    }
}
