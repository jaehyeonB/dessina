using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CapsuleMovement : MonoBehaviour
{
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }


    }
}                
                
                
                
                

    
