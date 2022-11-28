using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandLeftScript : MonoBehaviour
{
    public GameObject HandLeft;
    public ToolScript ToolLeftHand;

    public bool HandLeftOccupied = false;
    public bool HandLeftGloveEquipped = false;

    public GameObject InventoryManager;

    void Start()
    {
        InventoryManager = GameObject.FindGameObjectWithTag("IM");
        //Debug.Log(InventoryManager);
    }

    public void TryGloveEquip()
    {
        if (!HandLeftGloveEquipped) {
            HandLeftGloveEquipped = true;
            GetComponent<Renderer>().material.color = Color.blue;
        } else
        {
            Debug.Log("You are already wearing gloves.");
        }
        
    }

    private void OnMouseDown()
    {
        Debug.Log("Clicked Hand Left");
    }

    public bool IsHandOccupied()
    {
        return HandLeftOccupied;
    }
}
