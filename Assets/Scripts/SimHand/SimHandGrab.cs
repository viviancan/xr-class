 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimHandGrab : MonoBehaviour
{

    public GameObject collidingObject;

    public GameObject heldObject;
    
    private bool gripHeld;

    private VRInput controller;


    private void OnTriggerEnter(Collider other)
    {
        //saving/caching what we are interacting with
        collidingObject = other.gameObject;
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject == collidingObject)
        {
            collidingObject = null; 
        }
    }

    void Awake()
    {
        controller = GetComponent<VRInput>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            if(collidingObject && collidingObject.GetComponent<Rigidbody>())
            {
                heldObject = collidingObject;
                Grab();
            }
        }
        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            if (heldObject)
            {
                Release();
            }
        }
    }

    public void Grab()
    {
        Debug.Log("Grabbing!");
        heldObject.transform.SetParent(this.transform);
        heldObject.GetComponent<Rigidbody>().isKinematic = true;
    }

    public void Release()
    {
        heldObject.transform.SetParent(null);
        heldObject.GetComponent<Rigidbody>().isKinematic = false;
        heldObject = null;
    }
}
