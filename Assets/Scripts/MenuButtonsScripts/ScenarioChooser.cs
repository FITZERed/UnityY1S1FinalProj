using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenarioChooser : MonoBehaviour
{
    public void SaloonScenarioCosen()
    {
        SceneManager.LoadScene(3);
    }
    public void StationScenarioChosen()
    {
        SceneManager.LoadScene(4);
    }
    public void TrainScenarioChosen()
    {
        SceneManager.LoadScene(5);
    }
}
