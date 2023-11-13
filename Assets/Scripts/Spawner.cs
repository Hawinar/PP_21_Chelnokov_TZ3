using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _obstacle;

    private float _time;
    private float _timeBetweenSpawn = 5;

    private void Update()
    {
        if (Time.time > _time)
        {
            Spawn();
            _time = Time.time + _timeBetweenSpawn;
        }
    }

    private void Spawn()
    {
        Instantiate(_obstacle, new Vector3(Random.Range(-7f, 7f), 3, 0), new Quaternion(0, 0, 0, 0));
    }

}