using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
public class SpawnPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public bool host=true;
 public  GameObject[] MainPlayer;
  int i=0;
  int n=0;
  PhotonView view;
  
     public Transform[] pos;
       public static SpawnPlayer instance;
  private void Start()
    {
       instance=this;
      
    }

    

    // private void SpawnPlayer1()
    // {
    //     if(PhotonNetwork.IsMasterClient)
    //     photonView.RPC("RPCStartGame", RpcTarget.AllBuffered, 0, pos[0], Quaternion.identity);
    // }

    // [PunRPC] public void RPCStartGame(int i,Vector3 SpawnPos,Quaternion SpawnRot)
    // {
    //   PhotonNetwork.Instantiate(MainPlayer[i].name,SpawnPos,SpawnRot);
    // }


    private void Update() {
    
  }
  }

