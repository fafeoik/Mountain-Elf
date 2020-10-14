using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstText : MonoBehaviour
{


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Destroy(gameObject);
        }
    }
}
