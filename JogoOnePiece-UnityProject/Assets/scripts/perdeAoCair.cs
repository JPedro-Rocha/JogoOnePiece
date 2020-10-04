using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class perdeAoCair : MonoBehaviour
{

    public GameObject player;
    public GameObject plataforma;
    public Rigidbody2D rb;
    public float moveSpeed = 1f;
    private bool plataformaSpawned; 

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        //rb.AddForce(transform.up * moveSpeed);
        rb.transform.position += transform.up * Time.deltaTime * moveSpeed;

    }

    void OnTriggerEnter2D(Collider2D collider)
    {   
        
        
        if(collider.gameObject.tag.Equals("Player")){
            SceneManager.LoadScene ("GameOver");
            
        }
        else{
            Destroy(collider.gameObject);
        }
        
        
        Vector3 plataformaPosicao = new Vector3(Random.Range(-6.5f, 6.5f), player.transform.position.y +
                                                (2 + Random.Range(0.5f, 1.5f)));
        //Instantiate(plataforma, plataformaPosicao, Quaternion.identity);//correto


        /*plataformaSpawned = false;
        while (!plataformaSpawned)
        {
            if ((platformPosition - player.transform.position).magnitude < 5)
            {
                continue;
            }
            else
            {
                Instantiate(plataforma, platformPosition, Quaternion.identity);
                plataformaSpawned = true;
            }
        }*/
    }
}
