using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartPlatformerScene : MonoBehaviour
{
    public float a;
    public void RestartPlatformer()
    {
        SceneManager.LoadScene(2);
    }
}
    
