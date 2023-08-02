using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class tileScript : MonoBehaviourPunCallbacks
{
  
   [SerializeField] public int Tilenumber=0;
   [SerializeField] Transform orignalParent;
   Pickup pc;
   PhotonView view;
   Vector3 originalPos;
         void Start()
    {
        
        originalPos = gameObject.transform.position;
       
    }

    // Update is called once per frame
    void Update()
    {
        // if(!pickedUp && Input.GetKeyDown(KeyCode.X))
        //     pickUp();
       
    }

    [PunRPC]public tileScript   pickUp(Camera parent){
        
        base.photonView.RequestOwnership();
      transform.parent= parent.transform;
      transform.localPosition=new Vector3(3.31f,4.2f,10.31f);
      
        return this;
    }

    [PunRPC]public void placeInSlot(Transform slot){
        transform.parent=slot;
        transform.localPosition=Vector3.zero;
        transform.localRotation=Quaternion.Euler(Vector3.zero);
        transform.localScale=new Vector3(1f,1f,1f);
    }
    public void ResetPos(){
        transform.parent=orignalParent;
        gameObject.transform.position= originalPos;
        gameObject.transform.rotation=Quaternion.identity;  
       
    }
    [PunRPC]public void Put(Transform loc){
        transform.parent=null;
        transform.position=loc.position+ new Vector3(5f,0f,0f);
        transform.localRotation=Quaternion.Euler(Vector3.zero);
    }
}
