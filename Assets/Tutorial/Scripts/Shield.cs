using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Tutorial_Project
{
    public class Shield : MonoBehaviour
    {
        
        
        [SerializeField] private float _durability = 10f;
       // public GameObject ObjDestroy;
        public GameObject shieldPrefab;       
        public Transform spawnPosition;
        private bool _isSpawnShield;
        private int Level = 1;
        public void Init(float durability)
        {
            _durability = durability;
            
        }
        private void Start()
        {
            
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(1)) _isSpawnShield = true;
            
        }

        private void FixedUpdate()
        {
            if (_isSpawnShield)
            {
                _isSpawnShield = false;
                SpawnShield();
            }
        }


        private void SpawnShield()
        {
            var shieldObj = Instantiate(shieldPrefab, spawnPosition.position, spawnPosition.rotation);
            var shield = shieldObj.GetComponent<Shield>();
            shield.Init(Level * 10);
            shield.transform.SetParent(spawnPosition);
            Destroy(shieldObj, 3f);
        }
    }

}
