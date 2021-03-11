using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRInput : MonoBehaviour
{
    public Hands hand = Hands.Left;
    public float gripValue;

    private string gripAxis;

    // Start is called before the first frame update
    void Start()
    {
        gripAxis = $"{hand}Grip";
    }

    // Update is called once per frame
    void Update()
    {
        gripValue = Input.GetAxis(gripAxis);
    }
}

[System.Serializable]
public enum Hands
{
    Left,
    Right
}