using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LocateToVideoPlayer : MonoBehaviour{
    public GameObject myObject;
    string myObjectName;

    public static int videoIndex;
    public static string language, category;

    void Start(){
        myObjectName = myObject.name;
    }

    public void OnClick(){
        videoIndex = Int32.Parse(myObjectName);
        SceneManager.LoadScene("PlayerScene");
    }

    //return selected video's index
    public static int GetVideoIndex(){
        return videoIndex;
    }
}
