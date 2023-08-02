using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crossHair : MonoBehaviour
{
    
    [SerializeField] private GameObject camholder;
    [SerializeField] private float InteractRange;
    void Start()
    {
        
    }

  
  
    void Update()
    {
        RaycastHit ray;
        Vector3 origim=camholder.transform.position;
        Vector3 direction=camholder.transform.forward;
        if(Physics.Raycast(origim,direction,out ray,InteractRange))
            if(ray.collider.gameObject.GetComponent<tileScript>()!=null)
                {
                    Debug.Log(ray.collider.gameObject);
                }
    }
}
