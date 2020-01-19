using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{

    public float forwardSpeed = 1.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 nextPos = transform.position;
        nextPos.z += forwardSpeed * Time.deltaTime;
        transform.position = nextPos;
    }
}
