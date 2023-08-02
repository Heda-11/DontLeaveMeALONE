using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Voice.Unity;

public class VoiceChat : MonoBehaviour
{
    // Start is called before the first frame update
    Recorder VoiceComp;
    void Start()
    {
        VoiceComp= transform.GetComponent<Recorder>();
    }

    // Update is called once per frame
    void Update()
    {
    
      if(Input.GetKey(KeyCode.F))
      {
        VoiceComp.TransmitEnabled = true;
        Debug.Log("transmiting audio");
      }
      else
      {
          VoiceComp.TransmitEnabled = false;
        
      }
    }
    
    
    
    
}
