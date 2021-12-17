using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_ObstacleCollision : MonoBehaviour
{
    public string shapeType;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<AK_PlayerController>().playerShape != shapeType)
        {
            Destroy(collision.gameObject);
        }
        else if(collision.GetComponent<AK_PlayerController>().playerShape == shapeType)
        {
            
        }
    }
}
