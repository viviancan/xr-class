using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimHandAnimator : MonoBehaviour
{
    private Animator simHandAnimator;

    // Start is called before the first frame update
    void Start()
    {
        // filling the "bucket" line 7
        simHandAnimator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            SetAnimator(true);
        }

        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            SetAnimator(false);
        }
    }

    void SetAnimator(bool boolVal)
    {
        simHandAnimator.SetBool("isClosing", boolVal);
    }
}
