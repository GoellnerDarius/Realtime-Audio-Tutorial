using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //MOVE IN A CIRCLE horizontally
        transform.position = new Vector3(Mathf.Cos(Time.time), transform.position.y, Mathf.Sin(Time.time));
    }
}
