using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverCubo1 : MonoBehaviour
{
    public Transform[] cubo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            cubo[0].transform.position += Vector3.left;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            cubo[0].transform.position += Vector3.right;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            cubo[0].transform.position += Vector3.down;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            cubo[0].transform.position += Vector3.up;
        }
    }
}
