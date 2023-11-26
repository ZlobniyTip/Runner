using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _enemies;
    [SerializeField] private Healing _heal;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private float _delayBeforeSpawnEnemies;
    [SerializeField] private float _delayBeforeSpawnHeal;

    private void Start()
    {
        StartCoroutine(SpawnEnemies());
        StartCoroutine(SpawnHeal());
    }

    private IEnumerator SpawnEnemies()
    {
        var delayBeforeSpawn = new WaitForSeconds(_delayBeforeSpawnEnemies);

        while (true)
        {
            int spawnPointNumber = Random.Range(0, _spawnPoints.Length);
            int enemyNumber = Random.Range(0, _enemies.Length);

            Instantiate(_enemies[enemyNumber], _spawnPoints[spawnPointNumber].position, Quaternion.identity);

            yield return delayBeforeSpawn;
        }
    }

    private IEnumerator SpawnHeal()
    {
        var delayBeforeSpawn = new WaitForSeconds(_delayBeforeSpawnHeal);

        while (true)
        {
            int spawnPointNumber = Random.Range(0, _spawnPoints.Length);

            Instantiate(_heal, _spawnPoints[spawnPointNumber].position, Quaternion.identity);

            yield return delayBeforeSpawn;
        }
    }
}