using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lavamovement : MonoBehaviour
{

    public float speed = 15f;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, speed, 0);
    }
}
