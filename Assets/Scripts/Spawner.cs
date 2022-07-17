using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private int _secondsBetweenSpawn;

    private SpawnPoint[] _spawnPoints;
    private WaitForSeconds _waitForSeconds;

    private void Start()
    {
        _waitForSeconds = new WaitForSeconds(_secondsBetweenSpawn);
        _spawnPoints = FindObjectsOfType<SpawnPoint>();
        StartCoroutine(Spawn()); 
    }

    private IEnumerator Spawn()
    {    
        while (true)
        {
            _spawnPoints[Random.Range(0, _spawnPoints.Length)].Spawn();
            yield return _waitForSeconds;
        }           
    }
}
