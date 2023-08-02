
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class corridorScript_2 : MonoBehaviour
{
   
   public ParticleSystem ps;
    [SerializeField] Animator Anim;
   public AudioSource As;
    public AudioSource As1;
    AudioSource As2;
    public AudioClip Clip1;
    public AudioClip Clip2;
    public AudioClip Clip3;
    
    bool dooropen=true;
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
        
    }
  private void OnTriggerEnter(Collider other) {
        
 
            if(played==true){
            played= !played;
            As.Play();
            As1.Play();
            }          
            ps.Play();
         Invoke("OpenDoor",7f);
        
    }
    private void OpenDoor()
    {
        if(dooropen==true){
        dooropen=false;
        Debug.Log("OpeningDoor");
       Anim.Play("Base Layer.glass_door_open",0,0.25f);
        }
    }
}
