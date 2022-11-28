using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>
public class GloveBoxScript : InteractableScript
{
    public GameObject InventoryManager;
    public bool GloveExists = false;

    void Start()
    {
        InventoryManager = GameObject.FindGameObjectWithTag("IM");
    }

    private void OnMouseDown()
    {
        //Debug.Log("Clicked GloveBox");
        if (!GloveExists)
        {
            InventoryManager.GetComponent<InventoryScript>().SpawnGlove();
            GloveExists = true;
        } else
        {
            Debug.Log("A glove has already been spawned!");
        }
        
    }

}