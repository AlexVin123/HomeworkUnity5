using System.Collections;
using UnityEngine;

public class Spaner : MonoBehaviour
{
    [SerializeField] private int _secondsBetweenSpawn;
    private SpawnPoint[] _spawnPoints;

    void Start()
    {
        _spawnPoints = FindObjectsOfType<SpawnPoint>();
        StartCoroutine(Spawn()); 
    }

    private IEnumerator Spawn()
    {    
        while (true)
        {
            _spawnPoints[Random.Range(0, _spawnPoints.Length)].Spawn();
            yield return new WaitForSeconds(_secondsBetweenSpawn);
        }           
    }
}
