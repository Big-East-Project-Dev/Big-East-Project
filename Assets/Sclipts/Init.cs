using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*Initialize first scene Main*/
public class Init : MonoBehaviour
{   
    private const string InitializeSceneName = "Main";

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    public static void RuntimeInitializeApplication()
    {
        Debug.Log("RuntimeInitializeApplication");

        if (!SceneManager.GetSceneByName(InitializeSceneName).IsValid())
        {
            SceneManager.LoadScene(InitializeSceneName, LoadSceneMode.Additive);
        }
    }
}
