using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gerarLevel : MonoBehaviour
{
    public GameObject plataforma;
    public GameObject plataformaMovel;
    public GameObject plataformaFragil;
    public float larguraLevel;
    public int numeroPlataformas;
    public float minY = .2f;
    public float maxY = 1.5f; 
    public int controle;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < numeroPlataformas; i++)
        {   
            controle = Random.Range(1,7);
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-larguraLevel, larguraLevel);

            if(controle < 5){
                Instantiate(plataforma, spawnPosition, Quaternion.identity);
            }else if( controle >= 5 && controle < 6){
                Instantiate(plataformaFragil, spawnPosition, Quaternion.identity);
            }else{
                Instantiate(plataformaMovel, spawnPosition, Quaternion.identity);
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
