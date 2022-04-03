using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Tutorial_Project

{
    public class Player : MonoBehaviour
    {

       
        public Transform spawnPosition;
        private bool _isSpawnShield;
        private Vector3 _direction;
        public float speed = 2f;
        public float speedRotate = 400f;
        private bool _isSprint;

        

        private void Awake()
        {
            
        }
                
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
            //transform.Rotate(new Vector3 (0, Input.GetAxis("Mouse X") * speedRotate * Time.fixedDeltaTime, 0));
            transform.Rotate(Vector3.up, Input.GetAxis("Horizontal") * speedRotate * Time.fixedDeltaTime);


        }
        private void Move(float delta)
        {
            var FixedDirection = transform.TransformDirection(_direction.normalized);
            transform.position += FixedDirection * (_isSprint ? speed * 2 : speed) * delta;
            if (Input.GetKeyDown(KeyCode.Space))

            { 
            
            } 
        }
          
    }

}

