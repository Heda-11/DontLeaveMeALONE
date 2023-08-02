using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class UITransition : MonoBehaviour
{
    public CinemachineVirtualCamera currentCam;
    // Start is called before the first frame update
    void Start()
    {
        
        currentCam.Priority++;
    }

    // Update is called once per frame
    public void UpdateCamera(CinemachineVirtualCamera target)
    {
        
        currentCam.Priority--;
        currentCam=target;
        currentCam.Priority++;
    }
}
