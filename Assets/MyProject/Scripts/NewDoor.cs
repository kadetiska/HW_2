using UnityEngine;

public class NewDoor : MonoBehaviour
{
    [SerializeField] GameObject Door;

    private void OnTriggerEnter(Collider other)
    {
       
    }
    private void OnTriggerStay(Collider other)
    {
        print("hjjj");
        if (Input.GetKeyDown(KeyCode.E))
        {
            Door.SetActive(false);
            print("goooo");
        }
    }
}
