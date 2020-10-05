using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class aboutFluxo : MonoBehaviour
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

    public void Voltar(){
		SceneManager.LoadScene ("MenuInicial");
    }
}
