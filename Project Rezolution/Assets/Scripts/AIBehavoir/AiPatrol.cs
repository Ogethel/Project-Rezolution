using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;
using UnityEngine.Serialization;

[CreateAssetMenu(fileName = "Patrol", menuName = "Ai/Function/Patrol")]
public class AiPatrol : AiBase
{
    [HideInInspector] public GameAction sendCoroutine;
    public GameAction addPointList;
    public FloatData distance, holdTime;

    public List<Vector3Data> PatrolPoints { private get; set; }

    private int i;
    
    private void OnEnable()
    {
        PatrolPoints?.Clear();
        if (addPointList != null) addPointList.raise += AddPatrolPointList;
        i = 0;
    }

    private void AddPatrolPointList(object obj)
    {
        PatrolPoints = obj as List<Vector3Data>;
    }
    
    public override void RunAgent(NavMeshAgent agent)
    {
        Debug.Log(agent.remainingDistance);
        agent.SetDestination(PatrolPoints[i].value);
        
        if (((agent.remainingDistance >= distance.value))) 
            return;
            
        if (i < PatrolPoints.Count - 1)
        {
            i++;
        }
        else
        {
            i = 0;
        }
    }

    public override IEnumerator Nav(NavMeshAgent ai)
    {
        throw new System.NotImplementedException();
    }
}