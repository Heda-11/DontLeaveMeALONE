using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;

public class lvl3manager : MonoBehaviourPun
{
    public int sum=0;
    public int value=0;
    private PhotonView view;
    [SerializeField] private Material greenMat;
    [SerializeField] private Material redMat;
    [SerializeField] private Material oldMat; 
    [SerializeField] private GameObject[] spheres;
    
    public  int ansValue=7;
     public Animator anim;
  public Animator anim2;
  public string matId;
  int i=0;
    void Start()
    {
      view=GetComponent<PhotonView>();
   
    }

    // Update is called once per frame
    void Update()
    {
        
        if(sum==ansValue)
        {
             if(i==0)
            {
               photonView.RPC("NewMethod",RpcTarget.AllBuffered); 

            }
        }

    if(sum<0){
        for(int i=0;i<15;i++) 
        {
            spheres[i].GetComponent<MeshRenderer>().material=oldMat;
         }
                  for(int i=0;i>sum;i--) 
        {
             spheres[Mathf.Abs(i)].GetComponent<MeshRenderer>().material=redMat;
         }   
    }
    else
    {
        for(int i=0;i<15;i++) 
        {
         
            spheres[i].GetComponent<MeshRenderer>().material=oldMat;
        }
            for(int i=0;i<sum;i++) 
        {
            spheres[i].GetComponent<MeshRenderer>().material=greenMat;
        }
    }
    }

   [PunRPC] public void NewMethod()
    {
        i = 2;
        anim.Play("Base Layer.door_1_open", 0, 0.25f);
        anim2.Play("Base Layer.door_1_open", 0, 0.25f);
    }

     [PunRPC] public void updateSum(int a){
         sum+=a;
        //changeMat();
        if(sum>0)
        {
        photonView.RPC("changeMat",RpcTarget.All,"Green");
        }
        else if(sum<0)
        {
        photonView.RPC("changeMatToRed",RpcTarget.AllBuffered,"Red");
        } 
        
    } 
    [PunRPC] public void degradeSum(int a){
         sum-=a;
        //changeMat();
        photonView.RPC("changeMat",RpcTarget.AllBuffered,oldMat);
    }
   [PunRPC]public void addToSum(int a){
        value=a;
        // updateSum();
       photonView.RPC("updateSum",RpcTarget.AllBuffered,value);
    } 

        [PunRPC]public void removeFromSum(int a){
        value=a;
    //   degradeSum();
        photonView.RPC("degradeSum",RpcTarget.AllBuffered,value);
    }

[PunRPC] public void changeMat(string mat)
    {
     
        matId=mat;
    }
[PunRPC] public void changeMatToRed(string mat)
{
    matId=mat;
}



}
