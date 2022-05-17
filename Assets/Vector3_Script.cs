using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector3_Script : MonoBehaviour
{
    public Vector3 miVector;
    public GameObject miObject;
    // Start is called before the first frame update
    void Start()
    {
        miObject.transform.position = miVector;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
