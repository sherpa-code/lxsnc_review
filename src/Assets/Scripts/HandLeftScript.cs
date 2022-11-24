using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandLeftScript : MonoBehaviour
{
    public GameObject HandLeft;
    public ToolScript ToolLeftHand;

    public bool HandLeftOccupied = false;

    public GameObject InventoryManager;

    void Start()
    {
        InventoryManager = GameObject.FindGameObjectWithTag("IM");
        Debug.Log(InventoryManager);
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
