
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour {

    // Use this for initialization
    public Slider slider;
    public void SliderValueChanged () {
        AudioListener.volume =  slider.value ;
    }
}
