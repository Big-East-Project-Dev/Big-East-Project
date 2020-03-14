using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LocateToMain : MonoBehaviour{
    public void OnClick(){
        locateToMain();
    }
    public static void locateToMain(){
        SceneManager.LoadScene("Main");
        LanguageChanger.language="ja";
        CategoryChanger.category="kame";
    }
}
