using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetInstantiate : MonoBehaviour
{
    [Range(10, 15)]
    [SerializeField] private int targetsInRow;
    [Range(5, 10)]
    [SerializeField] private int rows;

    [Range(1, 2)]
    [SerializeField] private float targetDistanceX;
    [Range(0, 1)]
    [SerializeField] private float targetDistanceY;

    [SerializeField] private GameObject targetPrefab;
    [SerializeField] private Vector3 startPosition;

    private void Awake()
    {
        GameObject[,] TargetTable = new GameObject[targetsInRow, rows];

        for (int i = 0; i < rows; i++)
        {
            Vector3 newPosition = new Vector3(startPosition.x, startPosition.y - i * targetDistanceY, startPosition.z);

            for (int j = 0; j < targetsInRow; j++)
            {
               Transform target = GameObject.Instantiate(targetPrefab, new Vector3(newPosition.x + j * targetDistanceX, newPosition.y, newPosition.z), Quaternion.identity).transform;
               target.SetParent(transform);
            }
        }
    }
}
