using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    //인스펙터에서 봐야하니까 public
    public Cube cube; 
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"Sphere refer {cube.a}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
