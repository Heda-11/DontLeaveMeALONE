using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.SceneManagement;

public class connectionPhoton : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public static void StartConnectionFast()
    {
        PhotonNetwork.ConnectUsingSettings();
        

    }

    public override void OnConnectedToMaster() {
       Debug.Log("Connected to server");
        PhotonNetwork.JoinLobby();
    }
    public override void OnJoinedLobby()
    {
      
      
     PhotonNetwork.LoadLevel(SceneManager.GetActiveScene().buildIndex+1);
    
    }


    public override void OnDisconnected(DisconnectCause cause)
    {
        Debug.Log("disconnceted bc"+cause.ToString());
    }
   
}
