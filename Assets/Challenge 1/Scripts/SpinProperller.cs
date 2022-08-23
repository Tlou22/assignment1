using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinProperller : MonoBehaviour
{
    
    private float properllerSpeed = 700;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, properllerSpeed * Time.deltaTime );
    }
}
