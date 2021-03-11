using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimHandMove : MonoBehaviour
{
    public Transform location;
    public Vector3 position;



    // Start is called before the first frame update
    void Start()
    {
        transform.position = position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward);
    }
}
