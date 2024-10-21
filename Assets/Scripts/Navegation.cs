
using Unity.AI.Navigation;
using UnityEngine;
using UnityEngine.AI;

public class Navegation : MonoBehaviour
{
    private NavMeshModifier meshSurface;
    
    void Start()
    {
        meshSurface = GetComponent<NavMeshModifier>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter");
        if (other.TryGetComponent<NavMeshAgent>(out NavMeshAgent agent))
        {
            
            if (meshSurface.AffectsAgentType(agent.agentTypeID))
            {
                agent.speed /= NavMesh.GetAreaCost(meshSurface.area);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exit");
        
        if (other.TryGetComponent<NavMeshAgent>(out NavMeshAgent agent))
        {
           
            if (meshSurface.AffectsAgentType(agent.agentTypeID))
            {
                agent.speed *= NavMesh.GetAreaCost(meshSurface.area);
            }
        }
    }
}
