using UnityEngine;


public class Mine_Boom : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        print("Booom");
    }
}
