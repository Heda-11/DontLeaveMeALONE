using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class SkipVideo : MonoBehaviourPun
{
    public static SkipVideo sk;
    
    public void skipVideo()
    {
       
        PhotonNetwork.LoadLevel(SceneManager.GetActiveScene().buildIndex+1);
    }
    private void Update() {
        
    }
}
