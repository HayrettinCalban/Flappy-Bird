using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovements : MonoBehaviour
{
    [SerializeField] private float pipeSpeed;

    private void Start()
    {
        Destroy(gameObject, 2.8f);
    }
    private void Update()
    {
        transform.position += Vector3.left * pipeSpeed * Time.deltaTime;
    }
}
