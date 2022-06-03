using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CameraFlow : MonoBehaviour
{
    public Transform target;
    private Vector3 offset = new Vector3(10,10,10);
    private Vector3 tmp;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // try
        // {
        //     tmp  = new Vector3();
        //     // target.position = gameObject.GetComponentInParent<Formation>().GetCentralPoint();
        //     tmp = gameObject.GetComponentInParent<Formation>().GetCentralPoint();
        //     // transform.LookAt(offset + target.position);
        //     transform.LookAt(tmp);
        // }
        // catch (Exception e)
        // {
        //     Console.WriteLine(e.Message);
        //     return;
        // }

        Ray ray = new Ray(transform.position, -transform.up);  
        RaycastHit hit;  
        if(Physics.Raycast(ray, out hit, Mathf.Infinity))
        // if(Physics.Raycast(ray, out hit, 10))
        {  
            Debug.Log("object: " + hit.collider.name);  
            Debug.DrawLine(ray.origin, hit.point, Color.red);
            print("1");
        }

        print("2");
    }
}
