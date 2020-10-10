using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RPG.Movement;

namespace RPG.Combat
{
    public class Fighter : MonoBehaviour
    {
        [SerializeField] float weaponRange = 2f;

        Mover moverScript;
        Transform target;

        private void Start()
        {
            moverScript = GetComponent<Mover>();
        }

        private void Update()
        {
            if (target != null)
            {
                bool isInRange = Vector3.Distance(target.position, transform.position) < weaponRange;
                moverScript.MoveTo(target.position);

                if (isInRange)
                {
                    moverScript.Stop();
                    target = null;
                }
            }
        }

        public void Attack(CombatTarget combatTarget)
        {
            target = combatTarget.transform;
        }
    }
}
