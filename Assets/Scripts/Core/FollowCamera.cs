using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Core
{
    public class FollowCamera : MonoBehaviour
    {
        [SerializeField] Transform target;
        [SerializeField] float rotateSpeed = 5f;

        private float _rotation;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void LateUpdate()
        {
            transform.position = target.position;

            if (Input.GetKey(KeyCode.Q))
            {
                _rotation += rotateSpeed * Time.deltaTime;
                transform.rotation = Quaternion.Euler(0, _rotation, 0);
            }
            else if (Input.GetKey(KeyCode.E))
            {
                _rotation -= rotateSpeed * Time.deltaTime;
                transform.rotation = Quaternion.Euler(0, _rotation, 0);
            }
        }
    }
}
