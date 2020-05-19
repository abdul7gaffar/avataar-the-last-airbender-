using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dungeoncamers : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject target;
    public float damping = 1;
    Vector3 offset;
    void Start()
    {
        offset = transform.position - target.transform.position;

    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 desiredPosition = target.transform.position + offset;
        Vector3 position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * damping);
        transform.position = position;

        transform.LookAt(target.transform.position);
    }
    void Update()
    {
        
    }
}
