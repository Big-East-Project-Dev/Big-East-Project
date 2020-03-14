using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using System.Threading;
public class PlayVideo : MonoBehaviour{
    public RawImage rawImage;
    public Button button;
    public static double length;

    int videoIndex=-1;
    void Start(){
        videoIndex = LocateToVideoPlayer.GetVideoIndex();
        var language = LanguageChanger.GetLanguage();
        var category = CategoryChanger.getCategory();
        //Debug.Log(videoIndex);

        /*You can select videoClip easily to set $category, $videoIndex, $language in this code.*/
        var videoClip = Resources.Load<VideoClip>($"Videos/{category}/{videoIndex}_{language}");

        rawImage.GetComponent<VideoPlayer>().source = VideoSource.VideoClip;
        rawImage.GetComponent<VideoPlayer>().clip = videoClip;
        length = rawImage.GetComponent<VideoPlayer>().clip.length;

        rawImage.GetComponent<VideoPlayer>().Play();
    }


    public void OnClick(){
        if (rawImage.GetComponent<VideoPlayer>().isPlaying == true){
            rawImage.GetComponent<VideoPlayer>().Pause();
            button.GetComponent<Image>().sprite = Resources.Load<Sprite>($"Images/btn/play");
        }else{
            rawImage.GetComponent<VideoPlayer>().Play();
            button.GetComponent<Image>().sprite = Resources.Load<Sprite>($"Images/btn/stop");
        }
    }

    //return video's length
    public static double GetLength(){
        return length;
    }
   
}
