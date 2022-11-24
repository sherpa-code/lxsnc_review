using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandScript : MonoBehaviour
{
    public GameObject HandRight;
    public GameObject HandLeft;

    public ToolScript ToolRightHand;
    public ToolScript ToolLeftHand;

    public bool HandRightOccupied = false;
    public bool HandLeftOccupied = false;

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

    public bool IsHandOccupied(string LR)
    {
        if (LR == "left")
        {
            return HandLeftOccupied;
        }
        else if (LR == "right")
        {
            return HandRightOccupied;
        }
        else
        {
            throw new KeyNotFoundException();
        }
    }
}
