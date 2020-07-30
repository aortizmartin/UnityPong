using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalasMove : MonoBehaviour
{
    Rigidbody pala;
    int speed = 10;
    public string jugador;
    float movimiento;
    
      // Update is called once per frame
    void Update()
    {
        pala = GetComponent<Rigidbody>();
        if (jugador == "I")
        {
            movimiento = Input.GetAxis("VerticalIzq");
        }
        if (jugador == "D")
        {
            movimiento = Input.GetAxis("Vertical");
        }
        
        
        pala.velocity = new Vector3(0, movimiento * speed, 0);
    }
}
