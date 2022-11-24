using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 'Player' attributes, including name and Hands;
/// LeftHand is represented by the beige Cube Prefab in the Scene labeled "Hand";
/// RightHand is represented by the cursor.
/// </summary>
public class UserScript : MonoBehaviour
{
    public string UserName = "Dr. Van Person";
    public HandScript Hands;
    public HandRightScript RightHand;
    public HandLeftScript LeftHand;

    /// <summary>
    /// Attempt to handle the User applying one of their Hands to an Interactable.
    /// </summary>
    //public void DoInteraction(string handLR, InteractableScript interactableObject)
    //{
    //    if (Hands.IsHandOccupied(handLR)) {
    //        Debug.Log("Hand is currently occupied.");
    //    }
    //    else
    //    {
    //        // TODO: Route the action to the appropriate interactableObject code.
    //    }
    //}


    ///// <summary>
    ///// Attempt to handle the User applying their HandRight to an Interactable.
    ///// </summary>
    //public void DoInteraction(string handLR, InteractableScript interactableObject)
    //{
    //    if (Hands.IsHandOccupied(handLR))
    //    {
    //        Debug.Log("Hand is currently occupied.");
    //    }
    //    else
    //    {
    //        // TODO: Route the action to the appropriate interactableObject code.
    //    }
    //}

}