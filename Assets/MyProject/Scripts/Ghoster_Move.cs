using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghoster_Move : MonoBehaviour
{
    

    private void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime);
    }
}
