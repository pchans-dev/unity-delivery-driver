using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("collision!!!!");
    }

    void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Trigger!!");
    }
}
