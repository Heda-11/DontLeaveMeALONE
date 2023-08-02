using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class lever_1 : MonoBehaviour, interact
{   
    [SerializeField]   public int startValue;
    [SerializeField]   private GameObject outputGB;
    Vector3 leverPos;
    private PhotonView view;
    Vector3 leverOrignalPos;
     public AudioSource As1;
     public AudioClip Clip1;
 // Start is called before the first frame update
    void Start()
    {  As1.clip=Clip1;
        leverPos=new Vector3(this.transform.position.x,this.transform.position.y-8,this.transform.position.z);
        leverOrignalPos=this.transform.position;
        view=GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void startInteracting()
    {

        this.transform.position = Vector3.Lerp(leverOrignalPos, leverPos, 100f);
        As1.Play();
        view.RPC("sendOP",RpcTarget.All);
        Invoke("NewMethod",1f);

    }

    private void NewMethod()
    {
        this.transform.position = Vector3.Lerp(leverPos, leverOrignalPos, 40f);
    }

    [PunRPC]void sendOP(){
            outputGB.GetComponent<level2OPbox>().showOP(startValue);
        }
}
