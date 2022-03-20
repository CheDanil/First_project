using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Tutorial_Project
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private Player _player;
        void Start()
        {
            _player = FindObjectOfType<Player>();
        }

     
    }
}

