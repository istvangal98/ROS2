using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void CollisionEnter (Collision collision)
    {
        Debug.Log("Enter called");
    }
    void CollisionStay (Collision collision)
    {
        Debug.Log("Stay occuring..");
    }
    void CollisionExit (Collision collision)
    {
        Debug.Log("Exit called");
    }
}
