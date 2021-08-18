using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public Vector3 scaleChanger;
    public Vector3 positionChanger;
    public Vector3 rorationChanger;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += scaleChanger;
        transform.position += positionChanger;
        transform.Rotate(rorationChanger);
    }
}
