using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public AudioClip ambiente;
    // Start is called before the first frame update
    void Start()
    {
      AudioSource.PlayClipAtPoint(ambiente, Camera.main.transform.position);
    }
 
    // Update is called once per frame 
    void Update()
    {
        
    } 

    public void CarregarJogo(){
		SceneManager.LoadScene ("Jogo");
    }  

    public void CarregarAbout(){
		SceneManager.LoadScene ("about");
	}  

    public void CarregarInicial(){
		    SceneManager.LoadScene ("inicial");
	} 
}
