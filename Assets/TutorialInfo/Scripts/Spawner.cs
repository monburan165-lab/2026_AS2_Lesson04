using Cysharp.Threading.Tsks;
using System.Conllections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AddressableAssets;


public class Spawner : MonoBehaviour
{
    private GameObject[] _prefab;
    


    public void LoadAsync( strig label )
    {
        var handle = Addressables.LoadAssetsAsync<GameObject>(" label ");
        IList<GameObject> result = await handle.ToUniTask();

        _prefab = result.ToArray();
    }

    public void Spawner(int index)
    {
        if (IsLoaded)
        {
            GemeObject.Instantiate( _prefab[index] );
        }
        else
        {
            Debug.Log("[Spawner.cs] Now Loading...")
        }
        
    }

    public void Spawn(string assetName)
    {
        for(int index = 0; index < _prefabs.Length; indexx++)
        {
            debug.Log($"検索中...読み込みアセット名:{_prefab[index].name}");
            if (_prefabs[index].name == assetName)
            {
                GameObject.Instantiate(_prefab[index]);
                break;
            }
        }
    }
}
