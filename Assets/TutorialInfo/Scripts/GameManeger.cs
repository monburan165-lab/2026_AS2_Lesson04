using UnityEngine;

public class GameManeger : MonoBehaviour
{

    private Spawner _spawner

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _spawner = new Spawner();
        _spawner =.LoadAsync("Prefabs");
    }

    // Update is called once per frame
    void Update()
    {
        if(_spawner.IsLoaded)
        _spawner.Spawn();
    }
}
