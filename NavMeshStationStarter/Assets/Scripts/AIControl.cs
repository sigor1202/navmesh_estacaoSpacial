using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIControl : MonoBehaviour
{
    //variavel do tipo NavMeshAgent
    public NavMeshAgent agent;
    void Start()
    {
        //pe o componente e atribui a variavel 
        agent = this.GetComponent<NavMeshAgent>();
    }

    
}
