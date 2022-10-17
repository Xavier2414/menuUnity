using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cambiarImagen : MonoBehaviour
{

    public Image imagenUI;
    // Start is called before the first frame update
    void Start()
    {
        imagenUI = GameObject.Find("imagentuto").GetComponent<Image>();
      
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("q")) {
            imagenUI.sprite = Resources.Load<Sprite>("../Sprites/is");
   
        }

        if (Input.GetKeyDown("w"))
        {
            imagenUI.sprite = Resources.Load<Sprite>("../Sprites/are");
        }

    }
}
