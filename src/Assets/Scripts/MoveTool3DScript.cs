using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTool3DScript : MonoBehaviour
{
    private Camera cameraMain;
    private float cameraZDistance;
    
    // Start is called before the first frame update
    void Start()
    {
        cameraMain = Camera.main;
        cameraZDistance = cameraMain.WorldToScreenPoint(transform.position).z;
    }

    void OnMouseDrag()
    {
        Vector3 screenPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, cameraZDistance); // z-axis added to screen point
        Vector3 newWorldPosition = cameraMain.ScreenToWorldPoint(screenPosition); // screen point converted to world point
        transform.position = newWorldPosition;
    }
}
