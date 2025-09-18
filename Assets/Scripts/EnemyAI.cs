using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private NavMeshAgent navMeshAgent;

    void Update()
    {
        navMeshAgent.SetDestination(player.transform.position);
    }
}