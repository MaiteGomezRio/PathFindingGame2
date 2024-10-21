using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Unity.AI.Navigation;

public class Nav_TerrainModifier : MonoBehaviour
{
    private NavMeshModifier _meshSurface;
    void Start()
    {
        _meshSurface = GetComponent<NavMeshModifier>();
    }
    private void OnTriggerEnter(Collider other)
    {
        //Compruebo que lo que ha entrado es un agente
        if (other.TryGetComponent<NavMeshAgent>(out NavMeshAgent agent))
        {
            //Compruebo que el agent se ve afectado por este tipo de superficie
            if (_meshSurface.AffectsAgentType(agent.agentTypeID))
            {
                agent.speed /= NavMesh.GetAreaCost(_meshSurface.area);//Reducir la velocidad
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        //Compruebo que lo que ha salido es un agente
        if (other.TryGetComponent<NavMeshAgent>(out NavMeshAgent agent))
        {
            //Compruebo que el agent se ve afectado por este tipo de superficie
            if (_meshSurface.AffectsAgentType(agent.agentTypeID))
            {
                agent.speed *= NavMesh.GetAreaCost(_meshSurface.area);//Aumentar la velocidad
            }
        }
    }
}
