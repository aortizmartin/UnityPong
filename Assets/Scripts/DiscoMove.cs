using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscoMove : MonoBehaviour
{
    Rigidbody disco;
    float saqueX;
    float saqueY;
    int speed = 7;
    Vector3 direccion;

    // Start is called before the first frame update
    void Start()
    {
        saque();
    }

  
    public void saque()
    {
        disco = GetComponent<Rigidbody>();
        saqueX = Random.Range(-2, 2);
        saqueY = Random.Range(-2, 2);

        //Debug.Log(saque);
        if (saqueX == 0)
        {
            saqueX = 0.25f;
        }
        disco.velocity = new Vector3(saqueX * speed , saqueY * speed , 0);

    }
}
