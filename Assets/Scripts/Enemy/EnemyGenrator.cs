using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class EnemyGenrator : MonoBehaviour
{
    public static EnemyGenrator _EM;
    [SerializeField] private AssetReference _enemyGhost;
   public bool IsGenerated;
    private void Start()
    {
        _EM = this;
    }

    //loads Enemy using Addressables
    public void GenerateEnemy()
    {
        if (LightArea._canAttackPlayer)
        {
            _enemyGhost.LoadAssetAsync<GameObject>().Completed += (asyncOperationHandle) =>
            {
                if (asyncOperationHandle.Status == AsyncOperationStatus.Succeeded)
                {
                    Instantiate(asyncOperationHandle.Result);
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
