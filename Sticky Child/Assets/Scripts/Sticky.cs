using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sticky : MonoBehaviour
{

    public DistanceJoint2D stick;
    [SerializeField] float breakForce = 600f;
    public Collision2D stickedObject = null;
    public bool sticked;


    // Start is called before the first frame update
    void Start()
    {
        stick = gameObject.GetComponent<DistanceJoint2D>();
        //stick.breakForce = breakForce;
        stick.enabled = false;
        sticked = false;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.CompareTag("StickAble"))
        {
            if (stickedObject == null)
            {
                stickedObject = other;
                stick.connectedBody = stickedObject.gameObject.GetComponent<Rigidbody2D>();
                stick.enabled = true;
                sticked = true;
                letPlayerJump();
                releaseAdditionalStickedPoints();
            }
        }
    }

    public void releaseJoint()
    {
        stick.enabled = false;
        sticked = false;
        stick.connectedBody = null;
        //stick = gameObject.AddComponent<DistanceJoint2D>();
    }

    internal void setStickedObjectAsTriggered()
    {
        if (stickedObject != null)
        {
            stickedObject.gameObject.GetComponent<StickyObject>().onJump();
            stickedObject = null;
            releaseJoint();
        }
    }

    private void letPlayerJump()
    {
        PlayerManager.Instance.player.GetComponent<trajectoryScript>().canJumpNow();
    }

    private void releaseAdditionalStickedPoints()
    {
        PlayerManager.Instance.player.GetComponent<trajectoryScript>().checkStickedPoints();
    }
}
