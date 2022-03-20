using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Tutorial_Project

{
    public class Player : MonoBehaviour
    {

        public GameObject shieldPrefab;
        public Transform spawnPosition;
        private bool _isSpawnShield;
        private int Level = 1;

        private Vector3 _direction;
        public float speed = 2f;

        private bool _isSprint;

        private void Awake()
        {
            
        }
                
        void Start()
        {
            
        }


        void Update()
        {
            if (Input.GetMouseButtonDown(1))

                _isSpawnShield = true;

            _direction.x = Input.GetAxis("Horizontal");
            _direction.z = Input.GetAxis("Vertical");

            _isSprint = Input.GetButton("Sprint");
            
        }

       

        private void FixedUpdate()
        {
            if (_isSpawnShield)
            {
                _isSpawnShield = false;
                SpawnShield();
            }
            Move(Time.fixedDeltaTime);
                
            
        }
        private void SpawnShield()
        {
            var shieldObj = Instantiate(shieldPrefab, spawnPosition.position, spawnPosition.rotation);
            var shield = shieldObj.GetComponent<Shield>();
            shield.Init(Level * 10);

            shield.transform.SetParent(spawnPosition);
        }

        private void Move(float delta)
        {
            transform.position += _direction * (_isSprint ? speed * 2 : speed) * delta;
        }
          
    }

}

