using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level2inverter : MonoBehaviour,interact
{
  [SerializeField]   private lever_1 outputGB;
  [SerializeField]   private lever_1 outputGB1;
  [SerializeField]   private lever_1 outputGB2;
  [SerializeField]   private lever_1 outputGB3;
   Vector3 leverPos;
    Vector3 leverOrignalPos;
     public AudioSource As1;
     public AudioClip Clip1;
        void Start()
    {As1.clip=Clip1;
         leverPos=new Vector3(this.transform.position.x,this.transform.position.y-8,this.transform.position.z);
        leverOrignalPos=this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
       public void startInteracting(){
      
         this.transform.position = Vector3.Lerp(leverOrignalPos, leverPos, 100f);
             As1.Play();
        if(outputGB.startValue==1)
        {
            outputGB.startValue=0;
        }
        else
            outputGB.startValue=1;
         if(outputGB1.startValue==1)
        {
            outputGB1.startValue=0;
        }
        else
            outputGB1.startValue=1;
        if(outputGB2.startValue==1)
        {
            outputGB2.startValue=0;
        }
        else
            outputGB2.startValue=1;
         if(outputGB3.startValue==1)
        {
            outputGB3.startValue=0;
        }
        else
            outputGB3.startValue=1;
        
        Invoke("NewMethod",1f);
       }
       
 private void NewMethod()
    {
        this.transform.position = Vector3.Lerp(leverPos, leverOrignalPos, 40f);
    }

    
}
