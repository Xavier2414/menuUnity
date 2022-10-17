using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class sumar : MonoBehaviour
{
    private string input;
    private string input1;
    public string resultado;
    public TextMeshProUGUI mText;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReadStringInput(string s) {
        input = s;
        Debug.Log(input);
    

    }
    public void ReadStringInput1(string s)
    {
        input1 = s;
        Debug.Log(input1);


    }
    public void sumarNum( ) {


        int suma = 0;
        int x = int.Parse(input);
        int y = int.Parse(input1);

        suma = x + y;

        string num1 = suma.ToString();
        resultado = num1;
        Debug.Log(resultado);

        mText.text = resultado;

          
        
        
  
    }


}
