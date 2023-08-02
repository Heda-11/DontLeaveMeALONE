using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LEVEL3l : MonoBehaviour,interact
{
    [SerializeField] private GameObject lvl3GB;
    private lvl3manager lvl3Script;
    public int value;
    public bool state=false;
    Vector3 leverPos;
    Vector3 leverOrignalPos;
     public AudioSource As1;
     public AudioClip Clip1;
    void Start()
    {As1.clip=Clip1;
        lvl3Script=lvl3GB.GetComponent<lvl3manager>();
        leverPos=new Vector3(this.transform.position.x,this.transform.position.y-8,this.transform.position.z);
        leverOrignalPos=this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void startInteracting(){
        state=!state;
         As1.Play();
        if(state)
          {
              this.transform.position = Vector3.Lerp(leverOrignalPos, leverPos, 100f);
            lvl3Script.addToSum(value);
          
          }
        else if(!state)
          {
              this.transform.position = Vector3.Lerp(leverPos, leverOrignalPos, 40f);
            lvl3Script.removeFromSum(value);    
          }
    }
}
