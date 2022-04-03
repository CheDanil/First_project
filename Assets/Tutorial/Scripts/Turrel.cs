using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Tutorial_Project

{
    public class Turrel : MonoBehaviour
    {
        [SerializeField] private Player _player;
        [SerializeField] private float _speedRotate = 0.5f;
        [SerializeField] private GameObject _bulletPrefab;
        [SerializeField] private Transform _spawnPosition;
        void Start()
        {
            _player = FindObjectOfType<Player>();
            
        }

        private void Update()
        {
            if (Vector3.Distance(transform.position, _player.transform.position) < 3)
            {
                if (Input.GetMouseButtonDown(0)) Fire();
            }
        }


        void FixedUpdate()
        {
            var direction = _player.transform.position - transform.position;
            var stepRotate = Vector3.RotateTowards(transform.forward, direction, _speedRotate * Time.fixedDeltaTime, 0f);
            transform.rotation = Quaternion.LookRotation(stepRotate); 
        }

        private void Fire()
        {
            var bulletObj = Instantiate(_bulletPrefab, _spawnPosition.position, _spawnPosition.rotation);
            var bullet = bulletObj.GetComponent<Bullet>();
            bullet.Init(_player.transform, 10, 0.5f);
        }
    }
}
