using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine_Spawn : MonoBehaviour
{
    public GameObject minePrefab;
    public Transform spawnPosition;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var ghost = Instantiate(minePrefab, spawnPosition.position, spawnPosition.rotation);
        }
    }
}
