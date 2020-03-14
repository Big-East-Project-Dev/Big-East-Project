using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*public class Title{
    public Text titile;
}*/

public class LanguageChanger : MonoBehaviour{
    public GameObject[] Movies = new GameObject[5];
    public GameObject languageChanger,categoryChanger;
    public Text title;
    public Text BtnMsg;

    public static string language = "ja";

    public void OnClick(){
        if(CategoryChanger.getCategory()=="kame"){
            if (language == "ja"){
                title.text = "中国留学生之父・松本龟次郎";
                BtnMsg.text="Japanese version\n中国人留学生教育の父・松本亀次郎";
                languageChanger.GetComponentInChildren<Text>().text="日本語版";
                language = "ch";
            }else{
                title.text = "中国人留学生教育の父・松本亀次郎";
                BtnMsg.text="Chinese version\n中国留学生之父・松本亀次郎";
                languageChanger.GetComponentInChildren<Text>().text="中文版";
                language = "ja";
            }
        }
        
        categoryChanger.GetComponent<Image>().sprite=Resources.Load<Sprite>($"Images/btn/kame_{language}");
        for (int i = 0; i < 5; i++)Movies[i].GetComponent<Image>().sprite = Resources.Load<Sprite>($"Images/kame/{i + 1}_{language}");
    }

    public static string GetLanguage(){
        return language;
    }
}
