using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aguaController : MonoBehaviour
{   
    public float moveSpeed;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
         rb.transform.position += transform.right * Time.deltaTime * moveSpeed;
    }
}
