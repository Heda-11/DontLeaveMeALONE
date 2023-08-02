using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    tileScript tile;
    [SerializeField] public Camera FPScam;
    [SerializeField]float range=10f;

    PhotonView view;
    [SerializeField]bool pickedUp=false;
       tileScript t;
        tileScript Tile;
       
        void Start()
    {
        view=transform.GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
           Tile= Raycast();
        }    
        else if(Input.GetKeyDown(KeyCode.B))
        {
           
            Debug.Log(Tile+"");
            if(Tile==null) return;
            view.RPC("CheckMethod",RpcTarget.All);
        }
    }
    tileScript Raycast()
    {
        RaycastHit hit;
        if(Physics.Raycast(FPScam.transform.position,FPScam.transform.forward,out hit,range)){
            
            //del if not working[]
            if(hit.transform.GetComponent<interact>()!=null){
                hit.transform.GetComponent<interact>().startInteracting();
                return null;}
            //------------    
            tileScript ts=hit.transform.GetComponent<tileScript>();
            Slot slot=hit.transform.GetComponent<Slot>();
            if(pickedUp==false)
            {
            t=ts.pickUp(FPScam);
            pickedUp=true;
           
            }
            else if(slot!=null&&pickedUp==true)
            {
            
                Debug.Log(t+"");
                  
                t.placeInSlot(slot.transform);
                pickedUp=false; 
            }
            
        return t;
        }
        return null;
    }
    [PunRPC] public void CheckMethod()
    {
        Tile.Put(FPScam.transform);
        pickedUp=false;
    }
}
