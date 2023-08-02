using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class level2OpenDoor : MonoBehaviourPun
{
  [SerializeField]   private GameObject outputGB=null;
  [SerializeField]   private GameObject outputGB1=null;
  [SerializeField]   private GameObject outputGB2=null;
  [SerializeField]   private GameObject outputGB3=null;

  public Animator anim;
  public Animator anim2;
public AudioSource As;
    public AudioSource As1;
     public AudioClip Clip1;
    public AudioClip Clip2;
      private PhotonView view;
    int i=0;
    bool played=true;
    // Start is called before the first frame update
    void Start()
    {
        As.clip=Clip1;
        As1.clip=Clip2;
            
           
    }

    // Update is called once per frame
    void Update()
    {
       if(outputGB.GetComponent<level2OPbox>().finalVal==1&&outputGB1.GetComponent<level2OPbox>().finalVal==0&&outputGB2.GetComponent<level2OPbox>().finalVal==0&&outputGB3.GetComponent<level2OPbox>().finalVal==1)
        {
       if(i==0)
       {
           photonView.RPC("checkDoor",RpcTarget.All);
        
       }
       }
    }
  [PunRPC]public void checkDoor()
    {
        Debug.Log("chking");
        
            Debug.Log("open");
           i=2;
           if(played==true){
            played= !played;
            As.Play();
            As1.Play();
            }  
           anim.Play("Base Layer.door_2_open",0,0.25f);
            anim2.Play("Base Layer.door_2_open",0,0.25f);
          
        
    }

}
