using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vendor : MonoBehaviour
{

    Currency script;
    Inventory invScript;

    public GameObject vendorUI;

    public string itemType;
    public int cost;


    void Start()
    {
        vendorUI.SetActive(false);
        script = GameObject.FindWithTag("GameController").GetComponent<Currency>();
        invScript = GameObject.FindWithTag("GameController").GetComponent<Inventory>();
    }
    void OnTriggerEnter()
    {
        vendorUI.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    void OnTriggerExit()
    {
        vendorUI.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    public void BuyItem(GameObject objToCreate)
    {
        if (script.gold >= cost)
        {
            script.gold -= cost;
            GameObject i = Instantiate(objToCreate);
            i.transform.SetParent(invScript.invTab.transform);
            if (itemType == "sword1")
            {
                invScript.sword1 = true;
            }
        }
    }
}