using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class perdeAoCair : MonoBehaviour
{

    public GameObject player;
    public GameObject plataforma;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        Destroy(collider.gameObject);
        Instantiate(plataforma, new Vector2(Random.Range(-5.5f, 5.5f), player.transform.position.y +
                   (14 + Random.Range(0.5f, 1f))), Quaternion.identity);

    }
}
