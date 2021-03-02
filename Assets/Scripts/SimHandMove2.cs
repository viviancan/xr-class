using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimHandMove2 : MonoBehaviour
{
    public Transform location; //"location" game object
    public Vector3 position;
    public float moveSpeed;
    public float turnSpeed;
    private float sprintFactor = 8;

    // Start is called before the first frame update
    void Start()
    {
        print("game starting");
        print(gameObject.name);
        print("location: " + location.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) | Input.GetKey(KeyCode.W))
        { 
            DoTranslation(Vector3.forward, moveSpeed);
        }

        if (Input.GetKey(KeyCode.DownArrow) | Input.GetKey(KeyCode.S))
        {
            DoTranslation(Vector3.back, moveSpeed);
        }

        if (Input.GetKey(KeyCode.LeftArrow) | Input.GetKey(KeyCode.A))
        {
            DoTranslation(Vector3.left, moveSpeed);
        }

        if (Input.GetKey(KeyCode.RightArrow) | Input.GetKey(KeyCode.D))
        {
            DoTranslation(Vector3.right, moveSpeed);
        }


        // FOR ROTATIONS

        if (Input.GetKey(KeyCode.LeftShift))
        {
            //left
            if (Input.GetKey(KeyCode.Q))
            {
                DoRotation(Vector3.down, turnSpeed);
            }
            
            //right
            if (Input.GetKey(KeyCode.E))
            {
                DoRotation(Vector3.up, turnSpeed);
            }
            
            //up
            if (Input.GetKey(KeyCode.Z))
            {
                DoRotation(Vector3.left, turnSpeed);
            }
            
            //down
            if (Input.GetKey(KeyCode.C))
            {
                DoRotation(Vector3.right, turnSpeed);
            }
        }

        //For sprinting
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            Sprint();
        }

        if (Input.GetKeyUp(KeyCode.RightShift))
        {
            ResetMoveSpeed();
        }
    }

    void Sprint()
    {
        //https://answers.unity.com/questions/616090/sprint-script-for-fps.html
        moveSpeed *= sprintFactor;
    }
    void ResetMoveSpeed()
    {
        moveSpeed = 10.0f;
    }

    void DoTranslation(Vector3 direction, float speed)
    {
        transform.Translate(direction * Time.deltaTime * speed);
    }

    void DoRotation(Vector3 direction, float speed)
    {
        transform.Rotate(direction * Time.deltaTime * speed, Space.Self);
    }

}
