
using UnityEngine;
using UnityEngine.AI;


public class Nav_MoveToMouse : MonoBehaviour
{
    public Camera cam; 
    private Animator animator; 
    private NavMeshAgent agent; 

    void Start()
    {
        agent = GetComponent<NavMeshAgent>(); 
        animator = GetComponent<Animator>(); 
    }

    void Update()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition); 
        RaycastHit hit; 

       
        if (Physics.Raycast(ray, out hit))
        {
            
            agent.SetDestination(hit.point);
        }

        
        bool isMoving = agent.velocity.magnitude > 0.1f;
        animator.SetBool("IsMoving", isMoving); 
    }
}

