using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class Test : MonoBehaviour
//{
//    //public class Player : MonoBehaviour
//    //{

//    //    public GameObject shieldPrefab;
//    //    public GameObject ObjDestroy;
//    //    public Transform spawnPosition;
//    //    private bool _isSpawnShield;
//    //    private int Level = 1;
//    //    private Vector3 _direction;
//    //    public float speed = 2f;
//    //    public float speedRotate = 600f;
//    //    private bool _isSprint;



//    //    private void Awake()
//    //    {

//    //    }

//    //    void Start()
//    //    {
//    //        Destroy(ObjDestroy, 3f);
//    //    }


//    //    void Update()
//    //    {
//    //        if (Input.GetMouseButtonDown(1))

//    //            _isSpawnShield = true;
//    //        _direction.x = Input.GetAxis("Horizontal");
//    //        _direction.z = Input.GetAxis("Vertical");
//    //        _isSprint = Input.GetButton("Sprint");

//    //    }



//    //    private void FixedUpdate()
//    //    {
//    //        if (_isSpawnShield)
//    //        {
//    //            _isSpawnShield = false;
//    //            SpawnShield();
//    //        }
//    //        Move(Time.fixedDeltaTime);
//    //        //transform.Rotate(new Vector3 (0, Input.GetAxis("Mouse X") * speedRotate * Time.fixedDeltaTime, 0));
//    //        transform.Rotate(Vector3.up, Input.GetAxis("Horizontal") * speedRotate * Time.fixedDeltaTime);


//        }
//        //private void SpawnShield()
//        //{
//        //    var shieldObj = Instantiate(shieldPrefab, spawnPosition.position, spawnPosition.rotation);
//        //    var shield = shieldObj.GetComponent<Shield>();
//        //    shield.Init(Level * 10);
//        //    shield.transform.SetParent(spawnPosition);
//        //}

//        //private void Move(float delta)
//        //{

//        //    var FixedDirection = transform.TransformDirection(_direction.normalized);
//        //    transform.position += FixedDirection * (_isSprint ? speed * 2 : speed) * delta;



//        //}

//    }
//}
