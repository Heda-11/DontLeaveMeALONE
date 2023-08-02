using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
  public float sensX,sensY;
public Transform orientation;
float xRotation,yRotation;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState=CursorLockMode.Locked;
        Cursor.visible=false;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX=Input.GetAxis("Mouse X")*Time.deltaTime*sensX;
        float mouseY=Input.GetAxis("Mouse Y")*Time.deltaTime*sensY;
       
        xRotation-=mouseY;
        xRotation= Mathf.Clamp(xRotation,-90f,90f);
        transform.localRotation=Quaternion.Euler(xRotation,0,0);
        orientation.Rotate(Vector3.up*mouseX);
        }
}
