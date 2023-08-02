using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class PuzzleSolutiomn : MonoBehaviour
{
    [SerializeField] Slot slot1;
    [SerializeField] Slot slot2;
    [SerializeField] Slot slot3;
    [SerializeField] GameObject door;
    [SerializeField] GameObject door2;

    tileScript t1;
    tileScript t2;
    tileScript t3;
    int slot1code=0;
    int slot2code=0;
    int slot3code=0;
    [SerializeField] GetPuzzle puzzle;
    Vector3 openDoor;
    Vector3 openDoor2;
 
    PhotonView view;
     PhotonView view2;
    public AudioSource As;
    public AudioSource As1;
    public AudioClip Clip1;
    public AudioClip Clip2;
    bool played=true;
    // Start is called before the first frame update
    void Start()
    {
       view=transform.GetComponent<PhotonView>();
       
        As.clip=Clip1;
        As1.clip=Clip2;
       openDoor=new Vector3(door.transform.position.x-37f,door.transform.position.y,door.transform.position.z);
    
        openDoor2=new Vector3(door2.transform.position.x-37f,door2.transform.position.y,door2.transform.position.z);
       
       
        switch(puzzle.MatIndex)
        {
            case 0:
            slot1code=3;
            slot2code=1;
            slot3code=6;
            break;
            case 1:
            slot1code=2;
            slot2code=5;
            slot3code=1;
            break;
            case 2:
            slot1code=3;
            slot2code=6;
            slot3code=2;
            break;
            case 3:
            slot1code=4;
            slot2code=9;
            slot3code=8;
            break;
            case 4:
            slot1code=7;
            slot2code=1;
            slot3code=4;
            break;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
       t1= slot1.GetComponentInChildren<tileScript>();
       t2= slot2.GetComponentInChildren<tileScript>();
       t3= slot3.GetComponentInChildren<tileScript>();
       if(t1==null||t2==null||t3==null) return;
       if(t1.Tilenumber==slot1code&&t2.Tilenumber==slot2code&&t3.Tilenumber==slot3code)
        {
            Debug.Log("GOimg");
          
            view.RPC("OpenDoors",RpcTarget.All);
            
        }
        else if(t1!=null&&t2!=null&&t3!=null)
        {
            t1.ResetPos();
            t2.ResetPos();
            t3.ResetPos();
        }
    }

    [PunRPC]private void OpenDoors()
    {
        if(played==true)
        {
            As.Play();
            As1.Play();
            played= !played;
        }
       
        Debug.Log("Opening Doors");
        door.transform.position = Vector3.Lerp(door.transform.position, openDoor, 1f);
        door2.transform.position = Vector3.Lerp(door2.transform.position, openDoor2, 1f);
       
    }
}
