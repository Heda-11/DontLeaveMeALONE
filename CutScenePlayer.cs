using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
using Photon.Pun;
using System.IO;

public class CutScenePlayer : MonoBehaviourPun {
     public RawImage rawImage;
     public VideoPlayer videoPlayer;
     public AudioSource audioSource;
  
      public double time;
    public double currentTime;

    // Update is called once per frame
    void Update () {
        currentTime = videoPlayer.time;
        if (currentTime >= time-0.5f) {
            PhotonNetwork.LoadLevel(SceneManager.GetActiveScene().buildIndex+1);
        }
        if(Input.GetKeyDown(KeyCode.DoubleQuote))
        {
            SkipVideo.sk.skipVideo();
        }
    }
  void Start () {
     Cursor.visible=true;
     time =videoPlayer.clip.length;
          StartCoroutine(PlayVideo());
         
  }
  IEnumerator PlayVideo()
     {
          videoPlayer.Prepare();
          WaitForSeconds waitForSeconds = new WaitForSeconds(1);
          while (!videoPlayer.isPrepared)
          {
               yield return waitForSeconds;
               break;
          }
          rawImage.texture = videoPlayer.texture;
          videoPlayer.Play();
          audioSource.Play();
     }
}