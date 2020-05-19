using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookAtCamera : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject target;
    void Start()
    {
        
    }
    void LateUpdate()
    {
        transform.LookAt(target.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
