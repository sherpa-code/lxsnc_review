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
