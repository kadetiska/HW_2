using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine_Boom : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        print("Booom");
    }
}
