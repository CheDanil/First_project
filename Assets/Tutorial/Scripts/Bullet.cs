using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Tutorial_Project

{

    public class Bullet : MonoBehaviour
    {

        private Transform _target;
        private float _speed;

        public void Init(Transform target, float LifeTime, float speed)
        {
            _target = target;
            _speed = speed;
            Destroy(gameObject, LifeTime);
        }
        private void FixedUpdate()
        {
           // transform.position = Vector3.MoveTowards(transform.position, _target.position, _speed);
            transform.position += transform.forward * _speed * Time.fixedDeltaTime;
        }

    }


}