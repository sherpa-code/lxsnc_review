using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The Director GameObject uses DirectorScript to control flow in the given training scenario.
/// This scenario requires what has been outlined in <see cref="href="https://github.com/sherpa-code/lxsnc_review">my repository.</see>>
/// </summary>
public class DirectorScript : MonoBehaviour
{
    public GameObject ToolBench;
    public GameObject ToolSpawnPositions;
    public PatientScript Patient;
    public UserScript User;
    public InventoryScript InventoryManager;

    Vector3 spawnPositionDefault = new Vector3(0, 0, 0);
    Color brown = new Color(139f / 255f, 69f / 255f, 19f / 255f, 1f);

    public System.Random r = new System.Random();

    public static List<Color> someColors = new List<Color>()
    {
        new Color(139f / 255f, 69f / 255f, 19f / 255f, 1f),
        new Color(50f / 255f, 0f / 255f, 50f / 255f, 1f),
        new Color(255f / 255f, 255f / 255f, 255f / 255f, 1f),
        new Color(200f / 255f, 200f / 255f, 200f / 255f, 1f)
    };

    public List<Vector3> somePositions = new List<Vector3>()
    {
        new Vector3(0, 0, 0),
        new Vector3(1, 1, 1),
        new Vector3(2, 2, 2),
        new Vector3(3, 3, 3)
    };


    void Start()
    {
        Debug.Log("Hey Lxsnc folks! =)");

        ScenarioPrepare();
        ScenarioBegin();
    }

    /// <summary>
    /// Sets up the scenario:
    /// generates and spawns the requested objects (of type ToolScript) in a random order: syringe, medicine vial, and box of gloves.
    /// </summary>
    void ScenarioPrepare()
    {
        //CubeSpawnTest();
        //InventoryManager.PrepareTools();
        //SpawnEnvironmentInteractables(); // TODO: spawn glove box
        SpawnUser();
    }

    /// <summary>
    /// Spawns the interactable objects of the scenario into the Scene;
    /// </summary>
    void SpawnEnvironmentInteractables()
    {

    }

    /// <summary>
    /// Spawns the empty GameObject associated with the User;
    /// </summary>
    void SpawnUser()
    {
        SpawnTools();
        ConfigureUser();
    }

    /// <summary>
    /// Sets up the User to interact with this scenario;
    /// </summary>
    void ConfigureUser()
    {
        // todo
    }

    /// <summary>
    /// Initiates the interactivity of the User with the scenario;
    /// </summary>
    void ScenarioBegin()
    {
        //ScenarioEnd();
    }

    /// <summary>
    /// Handles the no-return control flow of the scenario;
    /// i.e. procedure success and fail states.
    /// </summary>
    void ScenarioEnd()
    {
        if (Patient.PatientIsIll)
        {
            ScenarioSuccess();
        }
        else
        {
            ScenarioFail();
        }
    }

    /// <summary>
    /// Control flow following Success in treating the Patient.
    /// </summary>
    void ScenarioSuccess()
    {

    }

    /// <summary>
    /// Control flow following Failure in treating the Patient.
    /// </summary>
    void ScenarioFail()
    {
        
    }






    /// <summary>
    /// 
    /// </summary>
    //private void prepareTools()
    //{
    //    for (int i = 0; i < numberOfTools; i++)
    //    {
    //        tools.Add(new ToolScript(i, "Syringe", true)); // create a syringe
    //        tools.Add(new ToolScript(i, "Medicine Vial", false)); // create a vial of medicine
    //        tools.Add(new ToolScript(i, "Box of Gloves", false)); // create a box of gloves
    //        //tools.Add(new ToolScript(i, "Glove", false)); // create a glove
    //    }

    //    shuffleTools();
    //}

    /// <summary>
    /// 
    /// </summary>
    //private void ShuffleTools()
    //{
    //    var r = new System.Random();
    //    var shuffledTools = new List<ToolScript>();
    //    var listCount = tools.Count;
    //    for (int i = 0; i < listCount; i++)
    //    {
    //        var listElement = r.Next(0, tools.Count);
    //        shuffledTools.Add(tools[listElement]);
    //        tools.Remove(tools[listElement]);
    //    }

    //    tools = shuffledTools;
    //    //shuffleTools();

    //    foreach (var tool in tools)
    //    {
    //        //Debug.Log("This tool is: " + tool.name);
    //    }
    //}

    /// <summary>
    /// Instantiates Tools that exist at the start of a scene in a random order.
    /// </summary>
    void SpawnTools()
    {
        //InventoryManager.Tools.Add(new ToolScript(0, false, spawnPositionDefault, ));
        //InventoryManager.Tools.Add(new ToolScript(0, false, spawnPositionDefault, "syringe"));


        Debug.Log("SpawnTools() fired");
        //Vector3 spawnLocation = ToolGetNextSpawnLocation(); // TODO // **************

        List<string> someToolNames = new List<string>() { "syringe", "medicineVial", "gloveBox", "glove" };
        //ToolScript syringe = new ToolScript(0, "Syringe", false, spawnLocationDefault, brown);
        //ToolScript medicineVial = new ToolScript(0, "Syringe", false, spawnLocationDefault, brown);
        //ToolScript gloveBox = new ToolScript(0, "Syringe", false, spawnLocationDefault, brown);
        //ToolScript glove = new ToolScript(0, "Syringe", false, spawnLocationDefault, brown);
        //List<ToolScript> Inventory.Tools = new List<ToolScript>();
        //Inventory.Tools.Add(syringe);
        //Inventory.Tools.Add(medicineVial);
        //Inventory.Tools.Add(gloveBox);
        //Inventory.Tools.Add(glove);

        //foreach (string toolName in someToolNames)
        //{
        //    Debug.Log("iterating over remaining someToolNames begins:");
        //    Debug.Log("someToolNames Count is "+someToolNames.Count);
        //    Debug.Log(toolName);
        //}



        while (InventoryManager.Tools.Count > 0)
        {
            Debug.Log("begin iterating over remaining Inventory.Tools iterates: ");
            Debug.Log(" Inventory.Tools Count is " + InventoryManager.Tools.Count);
            Debug.Log(" this tool is : " + InventoryManager.Tools[0].ToolName);
            InventoryManager.Tools.RemoveAt(0);
        }

        //while (someToolNames.Count > 0)
        //{
        //    Debug.Log("begin iterating over remaining someToolNames iterates: ");
        //    Debug.Log(" someToolNames Count is " + someToolNames.Count);
        //    Debug.Log(" this tool is : " + someToolNames[0]);
        //    someToolNames.RemoveAt(0);
        //}

        Debug.Log("while ends; Inventory.Tools should be empty");
        Debug.Log("Inventory.Tools Count is " + InventoryManager.Tools.Count);
    }

    public bool WasProcedureSuccess()
    {
        return Patient.PatientIsIll;
    }



    //void CubeSpawnTest()
    //{
    //    GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
    //    cube.name = "brown_cube";
    //    Color brown = new Color(139f / 255f, 69f / 255f, 19f / 255f, 1f);
    //    cube.GetComponent<Renderer>().material.color = brown;



    //    //cube.Add(ToolScript);
    //    cube.AddComponent(typeof(ToolScript));
    //}

    Vector3 GetRandomToolSpawnPosition()
    {
        // TODO
        Vector3 position = spawnPositionDefault;
        return position;
    }

}

//    /// <summary>
//    /// Refers to the InventoryManager to retrieve and instantiate Tools to be manipulated by the User in the scenario.
//    /// </summary>
//    void SpawnTools()
//    {
//        Debug.Log("SpawnTools() fired");
//        //Vector3 spawnLocation = ToolGetNextSpawnLocation(); // TODO // ******************************* IMPORTANT ASAP

//        List<string> someToolNames = new List<string>() { "syringe", "medicineVial", "gloveBox", "glove" };
//        ToolScript syringe = new ToolScript(0, "Syringe", false, spawnLocationDefault, brown);
//        ToolScript medicineVial = new ToolScript(0, "Syringe", false, spawnLocationDefault, brown);
//        ToolScript gloveBox = new ToolScript(0, "Syringe", false, spawnLocationDefault, brown);
//        ToolScript glove = new ToolScript(0, "Syringe", false, spawnLocationDefault, brown);
//        List<ToolScript> Inventory.Tools = new List<ToolScript>();
//        Inventory.Tools.Add(syringe);
//        Inventory.Tools.Add(medicineVial);
//        Inventory.Tools.Add(gloveBox);
//        Inventory.Tools.Add(glove);

//        //foreach (string toolName in someToolNames)
//        //{
//        //    Debug.Log("iterating over remaining someToolNames begins:");
//        //    Debug.Log("someToolNames Count is "+someToolNames.Count);
//        //    Debug.Log(toolName);
//        //}



//        while (Inventory.Tools.Count > 0)
//        {
//            Debug.Log("begin iterating over remaining Inventory.Tools iterates: ");
//            Debug.Log(" Inventory.Tools Count is " + Inventory.Tools.Count);
//            Debug.Log(" this tool is : " + Inventory.Tools[0].ToolName);
//            Inventory.Tools.RemoveAt(0);
//        }

//        //while (someToolNames.Count > 0)
//        //{
//        //    Debug.Log("begin iterating over remaining someToolNames iterates: ");
//        //    Debug.Log(" someToolNames Count is " + someToolNames.Count);
//        //    Debug.Log(" this tool is : " + someToolNames[0]);
//        //    someToolNames.RemoveAt(0);
//        //}

//        Debug.Log("while ends; Inventory.Tools should be empty");
//        Debug.Log("Inventory.Tools Count is " + Inventory.Tools.Count);
//    }
//}



//for (int i = 0; i < Inventory.Tools.Count; i++)
//{
//    SpawnTool(Inventory.Tools[i], i);
//}

//for (int i = Inventory.Tools.Count; i >= 0 ; i--)
//{
//    SpawnTool(Inventory.Tools[i], i);
//}

//foreach (var tool in Inventory.Tools.ToList()) // ToList() copies the list to safely iterate over it without encountering issues with iterating on something modified in the process
//{
//    SpawnTool(tool);
//}

//while (Inventory.Tools.Count > 0)
//{
//    someInt = r.Next(Inventory.Tools.Count - 1);
//    //int someInt = r.Next(Inventory.Tools.Count - 1);
//    //SpawnTool(Inventory.Tools[someInt], someInt);
//    //Inventory.Tools = Inventory.Tools.ToList();
//    Inventory.Tools.Remove(Inventory.Tools[someInt]);
//}

//foreach (string tool in Inventory.Tools) {
//    SpawnTool(tool, index);
//}

//SpawnTool("syringe");
//SpawnTool("medicine");
//SpawnTool("glovebox");
//SpawnTool("glove");










///// <summary>
///// Refers to the InventoryManager to retrieve and instantiate Tools to be manipulated by the User in the scenario.
///// </summary>
//private void SpawnTools()
//{
//    Debug.Log("SpawnTools()");
//    List<string> someToolNames = new List<string>() { "syringe", "medicineVial", "gloveBox", "glove" };


//    //foreach (string toolName in someToolNames)
//    //{
//    //    Debug.Log("iterating over remaining someToolNames begins:");
//    //    Debug.Log("someToolNames Count is "+someToolNames.Count);
//    //    Debug.Log(toolName);
//    //}

//    while (someToolNames.Count > 0) {
//        Debug.Log("begin iterating over remaining someToolNames iterates: ");
//        Debug.Log(" someToolNames Count is " + someToolNames.Count);
//        Debug.Log(" this tool is : " + someToolNames[0]);
//        someToolNames.RemoveAt(0);
//    }

//    Debug.Log("while ends; someToolNames should be empty");
//    Debug.Log("someToolNames Count is " + someToolNames.Count);



//    //for (int i = 0; i < Inventory.Tools.Count; i++)
//    //{
//    //    SpawnTool(Inventory.Tools[i], i);
//    //}

//    //for (int i = Inventory.Tools.Count; i >= 0 ; i--)
//    //{
//    //    SpawnTool(Inventory.Tools[i], i);
//    //}

//    //foreach (var tool in Inventory.Tools.ToList()) // ToList() copies the list to safely iterate over it without encountering issues with iterating on something modified in the process
//    //{
//    //    SpawnTool(tool);
//    //}

//    //while (Inventory.Tools.Count > 0)
//    //{
//    //    someInt = r.Next(Inventory.Tools.Count - 1);
//    //    //int someInt = r.Next(Inventory.Tools.Count - 1);
//    //    //SpawnTool(Inventory.Tools[someInt], someInt);
//    //    //Inventory.Tools = Inventory.Tools.ToList();
//    //    Inventory.Tools.Remove(Inventory.Tools[someInt]);
//    //}

//    //foreach (string tool in Inventory.Tools) {
//    //    SpawnTool(tool, index);
//    //}

//    //SpawnTool("syringe");
//    //SpawnTool("medicine");
//    //SpawnTool("glovebox");
//    //SpawnTool("glove");
//}

///// <summary>
///// Refers to the InventoryManager to retrieve and instantiate Tools to be manipulated by the User in the scenario.
///// </summary>
//private void SpawnTools()
//{
//    List<string> someToolNames = new List<string>() { "syringe", "medicineVial", "gloveBox", "glove" };
//    //List<string> Inventory.Tools = new List<string>() { "syringe", "medicineVial", "gloveBox", "glove" };

//    int someInt;



//    //for (int i = 0; i < Inventory.Tools.Count; i++)
//    //{
//    //    SpawnTool(Inventory.Tools[i], i);
//    //}

//    //for (int i = Inventory.Tools.Count; i >= 0 ; i--)
//    //{
//    //    SpawnTool(Inventory.Tools[i], i);
//    //}

//    //foreach (var tool in Inventory.Tools.ToList()) // ToList() copies the list to safely iterate over it without encountering issues with iterating on something modified in the process
//    //{
//    //    SpawnTool(tool);
//    //}

//    while (Inventory.Tools.Count > 0)
//    {
//        someInt = r.Next(Inventory.Tools.Count - 1);
//        //int someInt = r.Next(Inventory.Tools.Count - 1);
//        //SpawnTool(Inventory.Tools[someInt], someInt);
//        //Inventory.Tools = Inventory.Tools.ToList();
//        Inventory.Tools.Remove(Inventory.Tools[someInt]);
//    }

//    //foreach (string tool in Inventory.Tools) {
//    //    SpawnTool(tool, index);
//    //}

//    //SpawnTool("syringe");
//    //SpawnTool("medicine");
//    //SpawnTool("glovebox");
//    //SpawnTool("glove");
//}

///// <summary>
///// 
///// TODO: encapsulate in an enumeration of Tools
///// </summary>
///// <param name="toolToSpawn"></param>
///// <param name="index"></param>
//private ToolScript SpawnTool(string toolToSpawn)
//{
//    //ToolScript tool = new ToolScript(Tools.Count, toolToSpawn, false);
//    //GameObject Tool = GameObject.CreatePrimitive(PrimitiveType.Cube);
//    ////Tool.AddComponent(typeof(ToolScript));
//    //Tool.AddComponent(Type.GetType(ToolScript));
//    //Tool.ToolName = toolToSpawn;


//    //ToolModel.name = toolToSpawn;
//    //ToolModel.GetComponent<Renderer>().material.color = someColors[index];
//    //ToolModel.transform.position = somePositions[index];

//    //GameObject Tool = new GameObject()
//    return tool;

//}


///// <summary>
///// 
///// TODO: encapsulate in an enumeration of Tools
///// </summary>
///// <param name="toolToSpawn"></param>
///// <param name="index"></param>
//private void SpawnTool(string toolToSpawn, int index)
//{

//    GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
//    cube.name = toolToSpawn;
//    cube.GetComponent<Renderer>().material.color = someColors[index];
//    cube.transform.position = somePositions[index];
//    cube.AddComponent(typeof(ToolScript));

//    //switch (cube.name)
//    //{
//    //    case "syringe":
//    //        cube.GetComponent<Renderer>().material.color = someColors[index];
//    //        //cube.transform.position = somePositions[0]


//    //        //cube.Add(ToolScript);

//    //        break;
//    //    case "medicine":
//    //        cube.GetComponent<Renderer>().material.color = someColors[1];

//    //        break;
//    //    case "glovebox":
//    //        cube.GetComponent<Renderer>().material.color = someColors[2];

//    //        break;
//    //    case "glove":
//    //        cube.GetComponent<Renderer>().material.color = someColors[3];

//    //        break;
//}