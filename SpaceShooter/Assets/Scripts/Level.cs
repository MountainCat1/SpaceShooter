using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] private List<EnemyWave> enemyWaves;

    private void Start()
    {
        Debug.Log(JsonUtility.ToJson(new EnemyWaves()
        {
            enemyWaves = enemyWaves
        }));
    }
}
[System.Serializable]
public class EnemyWaves
{
    public List<EnemyWave> enemyWaves;
}