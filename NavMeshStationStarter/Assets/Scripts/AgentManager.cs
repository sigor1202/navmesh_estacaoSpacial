using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentManager : MonoBehaviour
{
    //lista de gameObjects
    GameObject[] agents;
    void Start()
    {
        //encontrea os objetos com a tag ai e atribui a lista
        agents = GameObject.FindGameObjectsWithTag("ai");
    }

    // Update is called once per frame
    void Update()
    {   //verifica se esta clicando com o mouse
        if(Input.GetMouseButtonDown(0))
        {   
            //variavel do tipo rayCast
            RaycastHit hit;
            //verifica onde esta clicando e se for valido seta o destrino para os objetos da lista agents
            if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition),out hit,100))
            {
                foreach (GameObject a in agents)
                    a.GetComponent<AIControl>().agent.SetDestination(hit.point);
            }
        }
    }
}
