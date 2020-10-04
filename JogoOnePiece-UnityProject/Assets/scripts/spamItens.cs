using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class spamItens : MonoBehaviour
{   
    public GameObject buggy;
    public GameObject kuro;
    public GameObject arlong;
    public GameObject smoke;
    public GameObject alvida;
    public int quantItens = 2;
    public int itensRestantes;
    public int wave = 0;
    private BoxCollider2D boxColl;
    // Start is called before the first frame update
    void Start()
    {
        boxColl = GetComponent<BoxCollider2D>();
        Invoke("create",5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    } 

    public void create(){


        int quantidade = wave + quantItens;
        int item = Random.Range(1, 10);
        itensRestantes = quantidade;

        for(int i = 0; i < quantidade; i++){

            Vector3 itemPosition = new Vector3(Random.Range(-7.0f, 7.0f), (7.0f + Random.Range(1.0f, 5.0f)), 0); 
            if(item >= 1 && item < 3){
                Instantiate(buggy, itemPosition, Quaternion.Euler(0, 0,0));
            }
            else if(item >= 3 && item < 5){
                Instantiate(alvida, itemPosition, Quaternion.Euler(0, 0,0));
            }
            else if(item >= 5 && item < 7){
                Instantiate(arlong, itemPosition, Quaternion.Euler(0, 0,0));
            }
            else if(item >= 7 && item < 9){
                Instantiate(kuro, itemPosition, Quaternion.Euler(0, 0,0));
            }else{
                Instantiate(smoke, itemPosition, Quaternion.Euler(0, 0,0));
            }
            

        }

        if(wave < 3){
            wave++;
        }
        
    } 


    public void diminuirItens()
    {
        itensRestantes--;

        if(itensRestantes == 0){
            Invoke("create",5f);
        }
    } 


    public void OnCollisionEnter2D(Collision2D collision){
         //Debug.Log(bombaRestantes);
        
        if(collision.gameObject.tag.Equals("item")){
                //boxColl.isTrigger = true;
                //collision.GameObject.destroy();
                diminuirItens();
                //Debug.Log(bombaRestantes);
        }
    }


}
