using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
  
    public Vector3 direction = Vector3.forward;



    void Update()
    {

        transform.Rotate( direction * Time.deltaTime, Space.Self);

    }
}
