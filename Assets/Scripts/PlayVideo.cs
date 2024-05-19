using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class PlayVideo : MonoBehaviour
{

    public VideoPlayer video;                     // video object
    public string sceneName;                      // scene name

    void Awake()
    {
        video = GetComponent<VideoPlayer>();      // find video
        video.Play();                             // play video
        video.loopPointReached += CheckOver;      // check if over


    }


    void CheckOver(UnityEngine.Video.VideoPlayer vp)
    {
        SceneManager.LoadScene(sceneName);
    }
}
