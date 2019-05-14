using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]    
public class FollowTransform : MonoBehaviour
{
    [SerializeField] private RefTransform _tranformToFollow;

    private NavMeshAgent _agent;

    private void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (_tranformToFollow?.value == null) return;
        _agent.SetDestination(_tranformToFollow.value.position);
        
        
    }
}
