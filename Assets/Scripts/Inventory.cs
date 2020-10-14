using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.SceneManagement;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    public GameObject invTab;

    public bool weaponActive = false;
    public bool sword1 = false;

    public int hpPotion = 0;

    public GameObject Weapon;


    void Start()
    {
        invTab.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Tab))
        {
            invTab.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else if (Input.GetKeyUp(KeyCode.Tab))
        {
            invTab.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (!weaponActive)
            {
                if (sword1)
                {
                    Weapon.SetActive(true);
                    weaponActive = true;
                }
            }
        }
        if (Input.GetKey(KeyCode.Q))
        {
                if (weaponActive)
                {
                    if (sword1)
                    {
                        Weapon.SetActive(false);
                        weaponActive = false;
                    }
                }
        }
    }
}