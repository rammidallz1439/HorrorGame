using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class EnemyGenrator : MonoBehaviour
{
    public static EnemyGenrator _EM;
     public AssetReference _enemyGhost;

    private GameObject _player;
   public bool IsGenerated;
    private void Start()
    {
        _EM = this;
        _player = GameObject.FindGameObjectWithTag("Player");
    }
   
    //loads Enemy using Addressables
    public void GenerateEnemy()
    {
        Vector3 pos = new Vector3(UnityEngine.Random.Range(1, 3), 0, UnityEngine.Random.Range(1, 3));
        
        if (LightArea._canAttackPlayer)
        {
            _enemyGhost.LoadAssetAsync<GameObject>().Completed += (asyncOperationHandle) =>
            {
                if (asyncOperationHandle.Status == AsyncOperationStatus.Succeeded)
                {
                    Instantiate(asyncOperationHandle.Result);
                    asyncOperationHandle.Result.transform.position = pos;
                    IsGenerated = true;
                }
             
                else
                {
                    Debug.Log("Failed To Load");
                    IsGenerated = false;

                }
            };

          

        }
    }


}
