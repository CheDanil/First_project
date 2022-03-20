using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{

    public GameObject GhostPrefab;
    public Transform spawnGhostPosition;
    private bool _isSpawnGhost;


    private void Awake()
    {

    }
    void Start()
    {
       
    }

    
    void Update()
    {
        if (Input.anyKeyDown)
        {
            _isSpawnGhost = true;
            Destroy(gameObject, 0.5f);
        }
           
    }

    private void FixedUpdate()
    {
        if (_isSpawnGhost)
        {
            _isSpawnGhost = false;
            SpawnGhost();
        }
       


    }

    private void SpawnGhost()
    {
        var ghostObj = Instantiate(GhostPrefab, spawnGhostPosition.position, spawnGhostPosition.rotation);
        var ghost = ghostObj.GetComponent<Ghost>();

        ghost.transform.SetParent(spawnGhostPosition);
    }
}
