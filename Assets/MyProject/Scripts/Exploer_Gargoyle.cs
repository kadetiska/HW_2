using UnityEngine;

public class Exploer_Gargoyle : MonoBehaviour
{
    [SerializeField] private Vector3 _Player;
    [SerializeField] private Vector3 _Triger;
    [SerializeField] private float _distance;
    [SerializeField] private float _rang =1.0f;
    [SerializeField] private Transform _target;
    [SerializeField] private Transform _triger;
    [SerializeField] private float _speed = 2.0f;
    private void LateUpdate()
    {
        _Player = _target.position;
        _Triger = _triger.position;
        _distance = Mathf.Sqrt((_Player - _Triger).sqrMagnitude);
        if (_distance <= _rang)
        {
            Vector3 targetDir = _target.position - transform.position;
            Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir,_speed * Time.deltaTime, 0.0F);
            transform.rotation = Quaternion.LookRotation(newDir);
            print("shot");
        }

    }
}
