using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScenes : MonoBehaviour
{
    [SerializeField] private string nextScene;

    public void ChangeScene()
    { 
        // Load the scene with the specified name.
        SceneManager.LoadScene(nextScene);
    }
}
