using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private float pipeSpawnerTime;
    [SerializeField] private GameObject pipesPrefab;
    [SerializeField] private float height;

    private void Start()
    {
        StartCoroutine(SpawnPipe());
    }
    private IEnumerator SpawnPipe()
    {
        while (true)
        {
            Instantiate(pipesPrefab,new Vector3(3f,Random.Range(-height,height),0), Quaternion.identity);
            yield return new WaitForSeconds(pipeSpawnerTime);
        }
    }
    
}
