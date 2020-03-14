using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CategoryChanger : MonoBehaviour{
    public GameObject[] Movies = new GameObject[5];
    public GameObject categoryChanger;
    public GameObject languageChanger,BtnMsg;
    public Canvas canvas;
    public Text title;
    public static string category = "kame";
    
    private void Awake(){
        canvas.GetComponent<Image>().color = new Color(0.8f, 0.95f, 1.0f, 1.0f);
    }
    
    public void OnClick(){
        if (category == "kame"){
            category = "kake";
            languageChanger.SetActive(false);
            BtnMsg.SetActive(false);
            title.text = "掛川市の自然と歴史";
            canvas.GetComponent<Image>().color = new Color(0.9f, 0.8f, 1.0f,1.0f);
        }else if (category == "kake"){
            category = "kame";
            languageChanger.SetActive(true);
            BtnMsg.SetActive(true);
            title.text = "中国人留学生教育の父・松本亀次郎";
            canvas.GetComponent<Image>().color = new Color(0.8f, 0.95f, 1.0f, 1.0f);
        }
        categoryChanger.GetComponent<Image>().sprite=Resources.Load<Sprite>($"Images/btn/{category}_ja");
        for (int i = 0; i < 5; i++)Movies[i].GetComponent<Image>().sprite = Resources.Load<Sprite>($"Images/{category}/{i + 1}_ja");
    }

    public static string getCategory(){
        return category;
    }
}

public static class getContents{
    
}