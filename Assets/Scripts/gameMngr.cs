using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameMngr : MonoBehaviour
{
    public int Objetivo;
    public Text GolesI;
    public Text GolesD;
    public Text Winner;
    public static bool finPartida;
   
    // Update is called once per frame
    void Update()
    {
        if (!finPartida)
        {
            GolesI.text = "" + GoalControl.golesI;
            GolesD.text = "" + GoalControl.golesD;
            if (GoalControl.golesI >= Objetivo)
            {
                Winner.text = "Gana Izquierdo";
                finPartida = true;
                Winner.enabled = true;
            }
            if (GoalControl.golesD >= Objetivo)
            {
                Winner.text = "Gana Derecho";
                finPartida = true;
                Winner.enabled = true;
            }
        }
      
    }
}
