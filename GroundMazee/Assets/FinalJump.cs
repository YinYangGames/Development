﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalJump : MonoBehaviour
{
    public int force;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            other.GetComponentInParent<Rigidbody>().AddForce(0, 0, force, ForceMode.Impulse);
    }
}
