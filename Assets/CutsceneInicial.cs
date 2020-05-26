using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class CutsceneInicial : MonoBehaviour
{
    private VideoPlayer video;
    private float playerCurrentFrame;
    private float playerFrameCount;

    public string proximaCena;

    // Start is called before the first frame update
    void Start()
    {
        video = GetComponent<VideoPlayer>();
        playerCurrentFrame = video.GetComponent<VideoPlayer>().frame;
        playerFrameCount = video.GetComponent<VideoPlayer>().frameCount;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            video.Stop();
            SceneManager.LoadScene(proximaCena);
        }

        else if (video.isPrepared)
        {
            if (!video.isPlaying)
            {
              SceneManager.LoadScene(proximaCena);
            }
        }
    }

   
}
