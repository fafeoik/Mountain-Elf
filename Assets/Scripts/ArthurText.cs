using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArthurText : MonoBehaviour
{
    public GameObject WinUI;

    void OnTriggerEnter()
    {
        WinUI.SetActive(true);
    }

    void OnTriggerExit()
    {
        WinUI.SetActive(false);
    }
}
