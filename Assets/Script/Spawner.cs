using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created 

    private float _spawnTimer = 0f;
    private float _spawnInterval = 1f;
    private float _spawnCount = 0;
    private float _spawnLimit = 10;
    private float _spawnPosition = 0f;
    public GameObject enemyPrefab;
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    void Update()
    {
      _spawnTimer += Time.deltaTime;
      if (_spawnTimer >= _spawnInterval)
      {
        _spawnTimer = 0f;
        _spawnCount++;
        if (_spawnCount < _spawnLimit)
        {
          SpawnEnemy();
        }
      }
          
    }
    private void SpawnEnemy()
    {
      GameObject enemy = GameObject.Instantiate(enemyPrefab);
      enemy.transform.position = transform.position;
      // enemy.SetActive(true);
    }
}
