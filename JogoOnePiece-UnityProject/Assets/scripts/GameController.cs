using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text scoreText;
    public int score = 0;
    public GameObject plataforma5;
    public GameObject plataforma4;
    public GameObject plataforma3;


    private int controle;

    // Start is called before the first frame update
    void Start()
    {
        //spawPlataformas();
        score = 0;
        scoreText.text = "Score:" + score;
    }

    // Update is called once per frame
    void Update()
    {

    } 

    public void instanciarItens(){
        
    }

    public void spawPlataformas()
    {

        Vector3 plataformaAnterior = new Vector3(0, 0, 0);
        Vector3 plataformaPosition;
        for (int i = 0; i < 4; i++)
        {
            // bool asteroidegerado = false;
            //while (!asteroidegerado)
            //{
            // Spawn an asteroid
            controle = controle * -1;
            if (i == 0)
            {
                plataformaPosition = new Vector3((Random.Range(-9.0f, 9.0f) * controle), (Random.Range(-5.0f, 0.0f)), 0);
            }
            else
            {
                plataformaPosition = new Vector3((Random.Range(-9.0f, 0.0f) * controle), (Random.Range(plataformaAnterior.y + 2f, 5.0f)), 0);
                plataformaAnterior = plataformaPosition;
            }

            //if ((asteroidPosition - nave.transform.position).magnitude < 4)
            //{
            //  continue;
            /*esse if vai checar se a posição do asteroide que vai ser spawnado
              é diferente da posição da nave, para não spawnar em cima da nave*/
            //}
            //else
            // {
            Instantiate(plataforma5, plataformaPosition, Quaternion.Euler(0, 0, 0));
            //asteroidegerado = true;
            //   }

            // }
        }


    }

    public void spawCenario()
    {

    }

    public void aumentarScore()
    {
        score++;
        scoreText.text = "Score:" + score;
        Debug.Log("score:" + score);
    }
}
