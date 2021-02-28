using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimHandMove2 : MonoBehaviour
{
    public Transform location;
    public Vector3 position;
    public float moveSpeed;
    public float turnSpeed;

    // Start is called before the first frame update
    void Start()
    {
        print("game starting");
        print(gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow) | Input.GetKey(KeyCode.W))
        {
            ResetMoveSpeed();

            if (Input.GetKey(KeyCode.RightShift))
            {
                Sprint();
            }

            DoTranslation(Vector3.forward, moveSpeed);
        }


        if (Input.GetKey(KeyCode.DownArrow) | Input.GetKey(KeyCode.S))
        {
            ResetMoveSpeed();

            if (Input.GetKey(KeyCode.RightShift))
            {
                Sprint();
            }

            DoTranslation(Vector3.back, moveSpeed);

        }

        if (Input.GetKey(KeyCode.LeftArrow) | Input.GetKey(KeyCode.A))
        {

            ResetMoveSpeed();

            if (Input.GetKey(KeyCode.RightShift))
            {
                Sprint();
            }

            DoTranslation(Vector3.left, moveSpeed);
        }

        if (Input.GetKey(KeyCode.RightArrow) | Input.GetKey(KeyCode.D))
        {
            ResetMoveSpeed();

            if (Input.GetKey(KeyCode.RightShift))
            {
                Sprint();
            }

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
    }

    void Sprint()
    {
        //https://answers.unity.com/questions/616090/sprint-script-for-fps.html
        moveSpeed = 80.0f;
    }

    void DoTranslation(Vector3 direction, float speed)
    {
        transform.Translate(direction * Time.deltaTime * speed);
    }

    void DoRotation(Vector3 direction, float speed)
    {
        transform.Rotate(direction * Time.deltaTime * speed, Space.Self);
    }

    void ResetMoveSpeed()
    {
        moveSpeed = 10.0f;
    }
}
