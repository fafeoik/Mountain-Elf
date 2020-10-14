using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Attack : MonoBehaviour
{

    Inventory Inv;
    public Image UIHP;
    public float HP = 1f;
    public GameObject Ragdoll;
    Animator anim;
    public GameObject trigger1;
    public GameObject DeathScreen;

    void Start()
    {
        Inv = FindObjectOfType<Inventory>();
        anim = gameObject.GetComponent<Animator>();
    }


    void Update()
    {
        UIHP.fillAmount = HP;

        if (HP <= 0)
        {
            gameObject.SetActive(false);
            Instantiate(Ragdoll, transform.position, transform.rotation);
            DeathScreen.SetActive(true);
            
        }

        if(Input.GetKey(KeyCode.Mouse0))
        {
           
            if (Inv.weaponActive)
            {
                anim.SetTrigger("attack");
            }
           
        }

        if(Input.GetKey(KeyCode.H))
        {
            if(Inv.hpPotion > 0 && HP != 1)
            {
                anim.SetTrigger("drink");
                Inv.invTab.SetActive(true);
                Destroy(GameObject.Find("PotionGreen(Clone)"));
                HP = 1f;
                Inv.hpPotion -= 1;
                Inv.invTab.SetActive(false);
            }

        }

        
    }
    void OnTriggerStay(Collider other)
    {
        if(other.tag == "Toxic")
        {
            HP -= Time.deltaTime / 10f;
        }
    }

    void OnTriggerEnter(Collider other)
    {
      if(other.tag == "EnemySword1")
        {
            HP -= 0.05f;
        }
    }
    void TriggerON()
    {
        trigger1.SetActive(true);
    }
    void TriggerOFF()
    {
        trigger1.SetActive(false);
    }
}
