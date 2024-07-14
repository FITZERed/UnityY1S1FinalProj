using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenarioChooser : MonoBehaviour
{
    public void SaloonScenarioCosen()
    {
        SceneManager.LoadScene(1);
    }
    public void StationScenarioChosen()
    {
        SceneManager.LoadScene(2);
    }
    public void TrainScenarioChosen()
    {
        SceneManager.LoadScene(3);
    }
}
