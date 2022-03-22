using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetTrigger : MonoBehaviour
{
void OnTriggerEnter (Collider other)
    {
        Debug.Log ("Trigger: " + other.gameObject.name);

    } 
}
