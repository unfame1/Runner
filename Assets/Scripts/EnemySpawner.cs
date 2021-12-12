using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private float _secondsBetweenSpawn;

    private float _elapserTime = 0;

    private void Update()
    {
        _elapserTime += Time.deltaTime;

        if (_elapserTime >= _secondsBetweenSpawn)
        {
            _elapserTime = 0;

            int spawnPointNumber = UnityEngine.Random.Range(0, _spawnPoints.Length);
            Instantiate(_enemyPrefab, _spawnPoints[spawnPointNumber]);
        }
    }
}
