using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gerarLevel : MonoBehaviour
{
    public GameObject plataforma;
    public float larguraLevel;
    public int numeroPlataformas;
    public float minY = .2f;
    public float maxY = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < numeroPlataformas; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-larguraLevel, larguraLevel);
            Instantiate(plataforma, spawnPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
