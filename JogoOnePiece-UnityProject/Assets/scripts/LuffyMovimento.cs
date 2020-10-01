using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuffyMovimento : MonoBehaviour
{
    public LuffyController controller;
    public float runSpeed = 40f;

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        controller.Move(Input.GetAxisRaw("Horizontal") * runSpeed * Time.fixedDeltaTime, false, false);
    }
}

