using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Tutorial_Project

{
    public class Bomb : MonoBehaviour
    {
        public GameObject destroyObj, destroyObj1, destroyObj2, destroyObj3;
        private void OnTriggerEnter(Collider other)

        {
             if (other.CompareTag("Player"))

                Destroy(destroyObj);
                Destroy(destroyObj1);
                Destroy(destroyObj2);
                Destroy(destroyObj3);

        }
        
    }
}
