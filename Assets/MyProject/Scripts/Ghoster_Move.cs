using UnityEngine;
using UnityEngine.AI;

public class Ghoster_Move : MonoBehaviour
{
    [SerializeField] Transform[] Points = new Transform[3];
    NavMeshAgent Ghoster;
    int randomPoint;

    private void Awake()
    {
        Ghoster = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        if(Ghoster.remainingDistance < 0.05f)
        {
            Randomaizing();
        }
    }
    private void Randomaizing()
    {
        randomPoint = Random.Range(0, 3);
        Ghoster.SetDestination(Points[randomPoint].position);
    }
}
