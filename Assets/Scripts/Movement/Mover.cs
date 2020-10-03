using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

namespace RPG.Movement
{
    public class Mover : MonoBehaviour
    {
        [SerializeField] Transform target;
        private NavMeshAgent agent;
        private Animator anim;
        //private Ray lastRay;


        private Vector3 velocity;
        private Vector3 localVelocity;
        private float speed;

        // Start is called before the first frame update
        void Start()
        {
            agent = GetComponent<NavMeshAgent>();
            anim = GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update()
        {
            UpdateAnimator();
        }

        public void GetPoint(Vector3 destination)
        {
            agent.destination = destination;
        }

        private void UpdateAnimator()
        {
            velocity = agent.velocity;
            localVelocity = transform.InverseTransformDirection(velocity);
            speed = localVelocity.z;

            anim.SetFloat("forwardSpeed", speed);
        }
    }
}
