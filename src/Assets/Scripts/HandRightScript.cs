using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandRightScript : MonoBehaviour
{
    public GameObject HandRight;
    public GameObject ToolRightHand;

    public bool HandRightOccupied = false;
    public GameObject InventoryManager;

    void Start()
    {
        InventoryManager = GameObject.FindGameObjectWithTag("IM");
        Debug.Log(InventoryManager);
    }

    private void OnMouseDown()
    {
        
    }

    public bool IsHandOccupied()
    {
        return HandRightOccupied;
    }
}
