using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyObject : MonoBehaviour
{
    [SerializeField] bool isBig = false;
    [SerializeField] Collider2D coll;
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void onJump()
    {
        if (!isBig)
        {
            rb.simulated = false;
            coll.enabled = false;
            Invoke("resetStickedObject", 0.15f);
        }
    }

    private void resetStickedObject()
    {
        rb.simulated = true;
        coll.enabled = true;
    }
}
