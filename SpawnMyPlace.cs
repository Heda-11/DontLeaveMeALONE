using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using System.IO;
public class SpawnMyPlace : MonoBehaviour
{
    // Start is called before the first frame update
        PhotonView view;
        GameObject myPlayerAvatar;
        Player[] allplayers;
        int n;
        
  
    void Start()
    {
       Invoke("InstantiatePlayer",1f);

    }

    private void InstantiatePlayer()
    {
        view = GetComponent<PhotonView>();
        allplayers = PhotonNetwork.PlayerList;
        foreach (Player p in allplayers)
        {
            if (p.IsLocal&&p.NickName=="Player1")
            {
                if(view.IsMine){
                Debug.Log("Player1 instantiating");
                myPlayerAvatar = PhotonNetwork.Instantiate("Player1",new Vector3(213.399994f,50.7999992f,115.900002f), Quaternion.identity);
                 break;
                }
            }
            else 
             {
                 Debug.Log("Player2 instantiating");
                 myPlayerAvatar = PhotonNetwork.Instantiate("Player2",new Vector3(839.200012f,50.7999992f,95.5999985f), Quaternion.identity);
           break;
            }
        }
       

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
