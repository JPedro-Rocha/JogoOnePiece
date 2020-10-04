using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataformaMovel : MonoBehaviour
{
    public float velocidade = 1f;
    private Rigidbody2D body;
    private BoxCollider2D boxColl;
    // Start is called before the first frame update

    void Start()
    {   
        boxColl = GetComponent<BoxCollider2D>();
        body = GetComponent<Rigidbody2D>();
        //body.velocity = new Vector3 (VelocidadeX, VelocidadeY,0);
    }

    // Update is called once per frame
    void Update() 
    {
        if(transform.position.x > 0.53f){
            Debug.Log("Text:");
            velocidade = -1f;
        }
        else if(transform.position.x < -8.09f){
            //Debug.Log("Text:");
            velocidade = 1f;
        }
        body.velocity = new Vector2 (velocidade,body.velocity.y);
    } 

   /* public void OnCollisionEnter2D(Collision2D collision){
        
        if(collision.gameObject.name == "parede1"){
            //boxColl.isTrigger = true;
            velocidade = /*velocidade  -1f;
        }

    } 

    public void OnTriggerEnter2D(Collider2D collider){
        
        if(collider.gameObject.layer == 8){
            boxColl.isTrigger = true;
            velocidade = velocidade -1f;
        }

    } */
}
