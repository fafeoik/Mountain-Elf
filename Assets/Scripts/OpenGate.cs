using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class OpenGate : MonoBehaviour
{
    public GameObject Gate;
    void OnTriggerEnter(Collider other)
    {
        Gate.GetComponent<Animator>().SetTrigger("Open");
    }
}
