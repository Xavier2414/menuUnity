using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class imgcambiante : MonoBehaviour
{

    public Image   imagenIU;

    void Start()
    {
        imagenIU = GameObject.Find("Image").GetComponent<Image>(); 

    }

      void Update()
    {
        
       if (Input.GetKeyDown("q")) {
            imagenIU.sprite = Resources.Load<Sprite>("./Assets/Sprites/descarga");
        }
    }
}

