using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    [SerializeField] Color32 havepack = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 notpack = new Color32(0, 0, 0, 1);

    bool isPackage = false;
    bool isBuff = false;
    SpriteRenderer spr;
    [SerializeField] player pl;
    private void Start()
    {
        spr = GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "package" && isPackage == false)
        {
            Debug.Log("Package Picked Up");
            spr.color = havepack;
            isPackage = true;
            Destroy(col.gameObject);
        }
        else if(col.gameObject.tag== "customer" && isPackage==true)
        {
            Debug.Log("Package Delievered");
            spr.color = notpack;
            isPackage = false;
        }
        else if(col.gameObject.tag== "power")
        {
            Debug.Log("Buff acquired");
            pl.sp = 20f;
            Destroy(col.gameObject);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Debuff !");
        pl.sp = 8f;
    }
}
