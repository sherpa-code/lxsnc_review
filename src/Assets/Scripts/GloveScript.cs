using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>
public class GloveScript : InteractableScript
{
    public GameObject InventoryManager;
    

    void Start()
    {
        InventoryManager = GameObject.FindGameObjectWithTag("IM");
        Debug.Log(InventoryManager);
    }

    private void OnMouseDown()
    {
        Debug.Log("Clicked GloveBox");
    }


    public void interactWithHand()
    {
        // TODO
    }

    public void OnCollisionEnter(Collision c)
    {
        TryGloveApply(c);
    }

    public void TryGloveApply(Collision c)
    {
        if (c.gameObject.tag == "HandLeft")
        {
            c.gameObject.GetComponent<Renderer>().material.color = Color.blue;
            Destroy(this);
        }
    }
}
