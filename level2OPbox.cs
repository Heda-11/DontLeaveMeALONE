using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class level2OPbox : MonoBehaviour
{
    public Material mat1;
    public Material mat0;
    public int finalVal=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void showOP(int inValue){
        if(inValue==1)
         gameObject.GetComponent<MeshRenderer>().material=mat1;
            finalVal=inValue;
        if(inValue==0)
         gameObject.GetComponent<MeshRenderer>().material=mat0;
        finalVal=inValue;
    }
}
