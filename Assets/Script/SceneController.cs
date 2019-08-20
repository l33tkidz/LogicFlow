using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void GotoMainScene()
    {
        SceneManager.LoadScene("Main");
    }

    public void GotoFactoryScene()
    {
        SceneManager.LoadScene("Factory");
    }

    public void GotoRobotScene()
    {
        SceneManager.LoadScene("Robot");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
