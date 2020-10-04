using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataformaFragil : MonoBehaviour
{ 
    public float time;
    
    private BoxCollider2D boxColl;
    private TargetJoint2D target;


    // Start is called before the first frame update
    void Start()
    {
        boxColl = GetComponent<BoxCollider2D>();
        target = GetComponent<TargetJoint2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    } 


    public void OnCollisionEnter2D(Collision2D collision){
        
        if(collision.gameObject.tag == "Player"){
            Invoke("queda", time);
        }

    } 


    public void queda(){
        target.enabled = false;
        boxColl.isTrigger = true;
    }
}
