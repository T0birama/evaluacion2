using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject autosenemigos = null;
    public float temporizador = 0;
    public int tiempoparaspawnear = 6;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      temporizador += Time.deltaTime;
        if(temporizador >= tiempoparaspawnear)
        {
            Instantiate(autosenemigos, gameObject.transform);
            temporizador = 0;
        }
    }
}
