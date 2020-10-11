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

                if (!isInRange)
                    moverScript.MoveTo(target.position);
                else
                    moverScript.Stop();
            }
        }

        public void Attack(CombatTarget combatTarget)
        {
            target = combatTarget.transform;
        }

        public void Cancel()
        {
            target = null;
        }
    }
}
