using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EcsenaJuego() {
        SceneManager.LoadScene("juego");

    }
    public void EcsenaImg()
    {
        SceneManager.LoadScene("img");

    }
    public void EcsenaAudio()
    {
        SceneManager.LoadScene("audio");

    }
    public void EcsenaSuma()
    {
        SceneManager.LoadScene("suma");

    }
    public void EcsenaVolver()
    {
        SceneManager.LoadScene("SampleScene");

    }





}
