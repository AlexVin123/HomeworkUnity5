using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;

    public void Spawn()
    {
        _enemy.transform.position = transform.position;
        Instantiate(_enemy);
    }
}
