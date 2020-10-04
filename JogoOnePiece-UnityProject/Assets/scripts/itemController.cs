using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemController : MonoBehaviour
{
    private BoxCollider2D boxColl;
    // Start is called before the first frame update
    void Start()
    {
        boxColl = GetComponent<BoxCollider2D>();
        GetComponent<Rigidbody2D>().AddForce(transform.up * Random.Range(-50.0f, 150.0f)); 
        GetComponent<Rigidbody2D>().angularVelocity = Random.Range(-0.0f, 90.0f);   
    }

    // Update is called once per frame
    void Update()
    {
        
    } 

    public void OnCollisionEnter2D(Collision2D collision){
         
        
        if(collision.gameObject.tag.Equals("Player")){
                //boxColl.isTrigger = true;
                Debug.Log("a");
                //collision.GameObject.destroy();
        }
    }
}
