using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryScript : MonoBehaviour
{
    public DirectorScript Director;
    public List<ToolScript> Tools;
    //public List<ToolScript> ToolsAll;
    //public List<GameObject> ToolsAllObjects;


    ///// <summary>
    ///// Builds collection of available Tools.
    ///// TODO: Parse this from ToolsJSON.JSON
    ///// </summary>
    //public void PrepareTools()
    //{
    //    ToolsAllObjects.AddComponent();
    //    //ToolsAll.Add(new ToolScript(0, "Syringe", false));
    //    //ToolsAll.Add(new ToolScript(1, "Vial", true));
    //    //ToolsAll.Add(new ToolScript(2, "Glove Box", false));
    //    //ToolsAll.Add(new ToolScript(3, "Glove", false));

    //    for (int i = 0; i < ToolsAll.Count; i++)
    //    {
    //        Debug.Log("PrepareTools() says - id: " + ToolsAll[i].ToolId
    //                    + " name: " + ToolsAll[i].ToolName
    //                    + " hasVial?: " + ToolsAll[i].ToolContainsMedicine
    //                    );
    //    }

    //    ShuffleTools();
    //}



    //private void ShuffleTools()
    //{
    //    var r = new System.Random();
    //    var shuffledTools = new List<ToolScript>();
    //    var listCount = ToolsAll.Count;
    //    for (int i = 0; i < listCount; i++)
    //    {
    //        var listElement = r.Next(0, ToolsAll.Count);
    //        shuffledTools.Add(ToolsAll[listElement]);
    //        ToolsAll.Remove(ToolsAll[listElement]);
    //        //Debug.Log("Tool " + ToolsAll[i].ToolName + " was generated into InventoryManager's 'Tools' List<GameObject> at index = " + i);
    //        //Debug.Log("The Tool generated is a " + X + " with " + Y + ".");
    //    }

    //    ToolsAll = shuffledTools;
    //    //shuffleTools();


    //    for (int i = 0; i < ToolsAll.Count; i++)
    //    {
    //        Debug.Log("last shuffletools()");
    //        Debug.Log("Tool " + ToolsAll[i].ToolName + " was generated into InventoryManager's 'Tools' List<GameObject> at index = " + i);
    //    }
    //}

}
