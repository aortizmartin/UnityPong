using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalControl : MonoBehaviour
{
    public GameObject ball;
    public static int golesI;
    public static int golesD;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Disco")
        {
            ball.SetActive(false);
            if (this.name == "GoalLeft")
            {
                golesD += 1;
            }
            if (this.name == "GoalRight")
            {
                golesI += 1;
            }
         
         StartCoroutine(sacar());
         
         
            
        }
    }
    IEnumerator sacar()
    {
        yield return new WaitForSeconds(3);
        if (!gameMngr.finPartida)
        {
            ball.SetActive(true);
            ball.transform.position = new Vector3(0, 0, 0);
        }

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
