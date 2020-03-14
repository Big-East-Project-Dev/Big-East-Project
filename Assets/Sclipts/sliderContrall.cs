using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class sliderContrall : MonoBehaviour{
    double length,nowTime,x=0.0;
    public RawImage rawImage;
    public Slider slider;
    int sum = 0;
    bool clicked = false;
    int movieMin,movieSec,currentMin,currentSec;
    public Text current_time,movie_time;

    // Update is called once per frame
    void Update(){
        length = PlayVideo.GetLength();
        slider.GetComponent<Slider>().maxValue = (float)rawImage.GetComponent<VideoPlayer>().length;
        slider.GetComponent<Slider>().minValue = 0.0f;
        if(rawImage.GetComponent<VideoPlayer>().isPlaying != true)rawImage.GetComponent<VideoPlayer>().time = slider.value;
        else slider.value = (float)rawImage.GetComponent<VideoPlayer>().time;
        Debug.Log("current value : "+slider.value.ToString());
        if(slider.GetComponent<Slider>().maxValue-slider.value<0.5)LocateToMain.locateToMain();
    }
}
