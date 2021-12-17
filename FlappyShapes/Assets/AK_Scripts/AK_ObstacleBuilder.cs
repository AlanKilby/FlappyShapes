using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_ObstacleBuilder : MonoBehaviour
{
    public Transform[] obstaclePosition;
    public Transform[] obstacleToSpawn;

    List<int> list = new List<int>();

    private void Start()
    {

        List<int> numbers = new List<int>();

        for (var index = 0; index < obstaclePosition.Length; index++)
            numbers.Add(index);

        list = new List<int>();

        while (numbers.Count > 0)
        {
            int position = Random.Range(0, numbers.Count);

            list.Add(numbers[position]);
            numbers.RemoveAt(position);
        }


        for(int i = 0; i < obstaclePosition.Length; i++)
        {
            Instantiate(obstacleToSpawn[list[i]], obstaclePosition[i].position, Quaternion.identity, obstaclePosition[i]);
        }
    }
}
