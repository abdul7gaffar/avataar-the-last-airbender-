using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatescript : MonoBehaviour
{
    // Start is called before the first frame update
    public float movespeed;
    public float rotatespeed;
    public float rotx1;
    public float roty1;
    void Start()
    {
        
    }

    // Update is called once per frame
     void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.LeftShift) && Input.GetKey("w"))
        {
            transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * movespeed* 2.5f;
        }
        else if (Input.GetKey("w")&& !Input.GetKey(KeyCode.LeftShift))
        {
            transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * movespeed;
        }
        else if (Input.GetKey("s"))
        {
            transform.position -= transform.TransformDirection(Vector3.forward) * Time.deltaTime * movespeed;
        }
         if (Input.GetKey("s") && !Input.GetKey("d"))
        {
            transform.position += transform.TransformDirection(Vector3.left) * Time.deltaTime * movespeed; 
        }
        else if (Input.GetKey("d") && !Input.GetKey("a"))
        {
            transform.position -= transform.TransformDirection(Vector3.left) * Time.deltaTime * movespeed;
        }

    }
    void Update()
    {
        rotx1 += Input.GetAxis("Mouse X") * Time.deltaTime * rotatespeed;
        roty1 -= Input.GetAxis("Mouse Y") * Time.deltaTime * rotatespeed;
        if (rotx1 < -90)
        {
            rotx1 = -90;
        }
        else if (rotx1 > 90)
        {
            rotx1 = 90;
        }
        transform.rotation = Quaternion.Euler(0, roty1, 0);
        GameObject.FindWithTag("MainCamera").transform.rotation = Quaternion.Euler(rotx1, roty1, 0);
    }
}
