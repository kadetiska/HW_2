using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyProject
{
    public class Spawn_Ghost : MonoBehaviour
    {
        public GameObject ghostPrefab;
        public Transform spawnPosition;
        public int GhostNum = 2;
        private int RealGhostNum = 0;
        private Vector3 spawnSdvig = Vector2.zero;
        void Start()
        {

        }

        void Update()
        {
            if(RealGhostNum != GhostNum)
            {
                GhostSpawn();
                RealGhostNum++;
            }
                
        }

        void GhostSpawn()
        {
            var ghost = Instantiate(ghostPrefab, spawnPosition.position, spawnPosition.rotation);
            spawnSdvig.x += 1;
            ghost.transform.position += spawnSdvig;
        }
    }
}