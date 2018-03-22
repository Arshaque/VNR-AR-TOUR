using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using Vuforia;


public class PlayController : MonoBehaviour
{

    public VideoPlayer videoPlayer;
    public GameObject playButton;
    
    // Use this for initialization
    void Start()
    {

    }
    private void Awake()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }
    public void playNow()
    {

        if (videoPlayer.isPlaying)
        {
            videoPlayer.Pause();
            playButton.SetActive(true);

        }
        else
        {
            videoPlayer.Play();
            playButton.SetActive(false);
        }

    }
    void OnMouseDown()
    {
        playNow();
    }
    
    void Update()
    {
        if (DefaultTrackableEventHandler.Inform.Name)
        {
            videoPlayer.Pause();
            playButton.SetActive(true);
        }
    }
}
