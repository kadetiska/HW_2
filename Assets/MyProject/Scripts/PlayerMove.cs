using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyProject
{
    public class PlayerMove : MonoBehaviour
    {

            public Vector3 _move;
            public float speed = 2f;

        void Start()
        {
        
        }

   
        void Update()
        {
            _move.x = Input.GetAxis("Horizontal");
            _move.z = Input.GetAxis("Vertical");
            
        }
         void FixedUpdate()
        {
            Move(Time.fixedDeltaTime);
        }
        private void Move (float delta)
        {
            transform.position += _move * speed * delta;
        }
    }
}
