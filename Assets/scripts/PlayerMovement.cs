using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int velocidad = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("auch");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("GANASTEEE");
    }





    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.up * Time.deltaTime * velocidad;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= transform.up * Time.deltaTime * velocidad;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += transform.right * Time.deltaTime * velocidad;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= transform.right * Time.deltaTime * velocidad;
        }
    }
}
