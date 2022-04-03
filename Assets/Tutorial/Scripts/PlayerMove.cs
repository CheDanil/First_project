using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Tutorial_Project

{
    public class PlayerMove : MonoBehaviour
    {
        public GameObject player;
        public int speedRotation = 1;
        public int speed = 2;
        public int jumpSpeed = 50;
        private bool _isSprint;
        private Vector3 _direction;
        public float speedRotate;

        void Start()
        {
           
           
        }

        void Update()
        {
            _direction.x = Input.GetAxis("Horizontal");
            _direction.z = Input.GetAxis("Vertical");
            _isSprint = Input.GetButton("Sprint");
        }

        private void FixedUpdate()
        {
            Move(Time.fixedDeltaTime);
            transform.Rotate(Vector3.up, Input.GetAxis("Horizontal") * speedRotate * Time.fixedDeltaTime);
        }

        private void Move(float delta)
        {
            var FixedDirection = transform.TransformDirection(_direction.normalized);
            transform.position += FixedDirection * (_isSprint ? speed * 2 : speed) * delta;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                transform.position += transform.up * jumpSpeed * Time.deltaTime;
            }
        }
    }
}

