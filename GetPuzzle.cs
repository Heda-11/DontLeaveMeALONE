using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPuzzle : MonoBehaviour
{
    [SerializeField]List<Material> materialList=new List<Material>();
       // Start is called before the first frame update
     public int MatIndex;
    public void Start()
    {
        
        MatIndex=UnityEngine.Random.Range(0,4);
        GetComponent<Renderer>().material=materialList[MatIndex];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
