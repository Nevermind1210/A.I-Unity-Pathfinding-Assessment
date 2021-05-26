using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Animations;

namespace AI
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class AgentSmith : MonoBehaviour
    {
        private NavMeshAgent agent;
        private Waypoint[] waypoints;
        private NavMeshLink jumpLink;
        private Animator anim;

        //Will give us a random waypoint in the array as a variable
        private Waypoint RandomPoint => waypoints[Random.Range(0, waypoints.Length)];

        // Start is called before the first frame update
        void Start()
        {
            agent = gameObject.GetComponent<NavMeshAgent>();
            // FindObjectsOfType gets every instance of this component in the scene
            waypoints = FindObjectsOfType<Waypoint>();
        }

        // Update is called once per frame
        void Update()
        {
            // Has the agent reached it's position?
            if (!agent.pathPending && agent.remainingDistance < 0.1f)
            {
                anim.SetTrigger("Walk");
                // Tell the agent to move to a random position in the scene waypoints
                agent.SetDestination(RandomPoint.Position);
            }
        }
    }
}