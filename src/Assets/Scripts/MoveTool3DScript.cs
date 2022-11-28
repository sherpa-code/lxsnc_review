using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTool3DScript : MonoBehaviour
{
    private Camera cameraMain;
    private float cameraZDistance;
    
    void Start()
    {
        cameraMain = Camera.main;
        cameraZDistance = cameraMain.WorldToScreenPoint(transform.position).z;
    }

    void OnMouseDrag()
    {
        Vector3 screenPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, cameraZDistance); // z-axis added to screen point
        //Vector3 screenPosition = new Vector3(Input.mousePosition.x, transform.position.y, cameraZDistance); // z-axis added to screen point
        //Vector3 screenPosition = new Vector3(Input.mousePosition.x, transform.position.y, cameraZDistance); // z-axis added to screen point
        //Vector3 screenPosition = new Vector3(Input.mousePosition.x, (float)0.5, cameraZDistance); // z-axis added to screen point
        Vector3 newWorldPosition = cameraMain.ScreenToWorldPoint(screenPosition); // screen point converted to world point
        transform.position = newWorldPosition;
    }
}
