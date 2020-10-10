using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

namespace RPG.Movement
{
    public class Mover : MonoBehaviour
    {
        [SerializeField] Transform target;
        private NavMeshAgent navMeshAgent;
        private Animator anim;
        //private Ray lastRay;


        private Vector3 velocity;
        private Vector3 localVelocity;
        private float speed;

        // Start is called before the first frame update
        void Start()
        {
            anim = GetComponent<Animator>();
            navMeshAgent = GetComponent<NavMeshAgent>();
        }

        // Update is called once per frame
        void Update()
        {
            UpdateAnimator();
        }

        public void MoveTo(Vector3 destination)
        {
            navMeshAgent.destination = destination;
            navMeshAgent.isStopped = false;
        }

        public void Stop()
        {
            navMeshAgent.isStopped = true;
        }

        private void UpdateAnimator()
        {
            velocity = navMeshAgent.velocity;
            localVelocity = transform.InverseTransformDirection(velocity);
            speed = localVelocity.z;

            anim.SetFloat("forwardSpeed", speed);
        }
    }
}
