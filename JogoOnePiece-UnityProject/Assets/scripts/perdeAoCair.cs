using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class perdeAoCair : MonoBehaviour
{

    public GameObject player;
    public GameObject plataforma;
    public Rigidbody2D rb;
    public float moveSpeed = 10f;
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
        rb.AddForce(transform.up * moveSpeed);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        Destroy(collider.gameObject);
        /*Instantiate(plataforma, new Vector2(Random.Range(-10.5f, 10.5f), player.transform.position.y +
                   (5 + Random.Range(0.5f, 1f))), Quaternion.identity);*/

        plataformaSpawned = false;
        while (!plataformaSpawned)
        {
            //Vector3 platformPosition = new Vector3(Random.Range(-15f, 15f), player.transform.position.y +
            //Random.Range(3f, 5 f), 0f);
            Vector3 platformPosition = Random.insideUnitCircle * 7;
            if ((platformPosition - player.transform.position).magnitude < 5)
            {
                continue;
            }
            else
            {
                Instantiate(plataforma, platformPosition + player.transform.position, Quaternion.identity);
                plataformaSpawned = true;
            }
        }
    }
}
