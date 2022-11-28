using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The Director GameObject uses DirectorScript to control flow in the given training scenario.
/// This scenario requires what has been outlined in <see cref="href="https://github.com/sherpa-code/lxsnc_review">my repository.</see>>
/// </summary>
public class DirectorScript : MonoBehaviour
{
    public GameObject ToolBench;
    //public GameObject ToolSpawnPositions;
    
    public PatientScript Patient;
    public UserScript User;
    public InventoryScript InventoryManager;
    public System.Random r = new System.Random();

    Vector3 spawnPositionDefault = new Vector3(0, 0, 0);
    Color brown = new Color(139f / 255f, 69f / 255f, 19f / 255f, 1f);

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


/// <summary>
/// Let'sa go!
/// </summary>
    void Start()
    {
        Debug.Log("Hey Lxsnc folks! =)");

        //toolSpawnPositionList.Add(ToolSpawnPosition1);
        //toolSpawnPositionList.Add(ToolSpawnPosition2);
        //toolSpawnPositionList.Add(ToolSpawnPosition3);

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
        InventoryManager.PrepareTools();
        SpawnUser();
    }


    /// <summary>
    /// Spawns the interactable objects of the scenario into the Scene.
    /// </summary>
    void SpawnEnvironmentInteractables()
    {

    }


    /// <summary>
    /// Spawns the empty GameObject associated with the User.
    /// </summary>
    void SpawnUser()
    {
        InventoryManager.SpawnTools();
        ConfigureUser();
    }


    /// <summary>
    /// Sets up the User to interact with this scenario.
    /// </summary>
    void ConfigureUser()
    {
        // TODO
    }


    /// <summary>
    /// Initiates the interactivity of the User with the scenario.
    /// </summary>
    void ScenarioBegin()
    {
        // TODO
    }


    


    /// <summary>
    /// Used to check if the Patient is still in an 'ill' state.
    /// </summary>
    /// <returns></returns>
    public bool WasProcedureSuccess()
    {
        return Patient.PatientIsIll;
    }


    /// <summary>
    /// Handles the no-return control flow of the scenario; i.e. procedure success and fail states.
    /// </summary>
    void ScenarioEnd()
    {
        if (WasProcedureSuccess())
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
    /// TODO: implement a success message using UI.
    /// </summary>
    public void ScenarioSuccess()
    {
        Debug.Log("Congratulations, the Patient has recovered.");
    }

    /// <summary>
    /// Control flow following Failure in treating the Patient.
    /// /// TODO: implement a failure message using UI.
    /// </summary>
    public void ScenarioFail()
    {
        Debug.Log("Unfortunately, the Patient has failed to recover.");
    }


    /// <summary>
    /// Uses the in-Scene Env_Tool_SpawnPosition GameObjects to get one of three random spawn locations.
    /// </summary>
    /// <returns>A Vector3 from a GameObject in the Scene.</returns>
    //public Vector3 GetRandomToolSpawnPosition()
    //{
    //    int i = r.Next(0, toolSpawnPositionList.Count);
    //    Vector3 position = toolSpawnPositionList[i].transform.position;
    //    toolSpawnPositionList.RemoveAt(i);
    //    return position;
    //}


    /// <summary>
    /// Uses the in-Scene Env_Tool_SpawnPosition GameObjects to get one of three random spawn locations.
    /// </summary>
    /// <returns>A Vector3 from a GameObject in the Scene.</returns>
    //public Vector3 GetRandomToolSpawnTransform()
    //{
    //    int i = r.Next(0, toolSpawnPositionList.Count);
    //    Vector3 position = toolSpawnPositionList[i].transform;
    //    toolSpawnPositionList.RemoveAt(i);
    //    return transform;
    //}

    //void CubeSpawnTest()
    //{
    //    GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
    //    cube.name = "brown_cube";
    //    Color brown = new Color(139f / 255f, 69f / 255f, 19f / 255f, 1f);
    //    cube.GetComponent<Renderer>().material.color = brown;


    //    //cube.Add(ToolScript);
    //    cube.AddComponent(typeof(ToolScript));
    //}


}