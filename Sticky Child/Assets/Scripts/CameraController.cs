using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    [SerializeField] float diss = -10f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("followPlayer");
    }

    IEnumerator followPlayer()
    {
        while (true)
        {
            transform.position = new Vector3(PlayerManager.Instance.player.transform.position.x, PlayerManager.Instance.player.transform.position.y, diss);
            yield return null;
        }
    }
}
