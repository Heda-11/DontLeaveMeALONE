using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;
using Photon.Realtime;

public class JoinRoom : MonoBehaviourPunCallbacks
{
 public InputField CreateRoomInput;
 public InputField JoinRoomInput;
 

public void CreateRoom(){
    
  
    PhotonNetwork.CreateRoom(CreateRoomInput.text);

}
public void JoinTheRoom(){
PhotonNetwork.JoinRoom(JoinRoomInput.text);
}
public override void OnJoinedRoom(){
    
   
    Player[] players=PhotonNetwork.PlayerList;
   
        if(PhotonNetwork.PlayerList.Length==1)      
        {players[0].NickName="Player1";
        }
        if(PhotonNetwork.PlayerList.Length==2)
        {players[1].NickName="Player2";
        }
    PhotonNetwork.LoadLevel("IntoCutscene");
    
}

}
