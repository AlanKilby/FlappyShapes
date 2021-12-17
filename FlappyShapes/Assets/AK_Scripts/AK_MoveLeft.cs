using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_MoveLeft : MonoBehaviour
{
    public float movementSpeed;

    private void Update()
    {
        transform.Translate(Vector2.left * movementSpeed * Time.deltaTime);
    }
}
