 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimHandGrab : MonoBehaviour
{

    public GameObject collidingObject;

    public GameObject heldObject;

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
    // Start is called before the first frame update
    void Start()
    {
        
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
    }

    public void Grab()
    {
        heldObject.transform.SetParent(this.transform);
    }

    public void Release()
    {

    }
}
