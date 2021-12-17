using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_PlayerController : MonoBehaviour
{
    public float playerVelocity;

    Rigidbody2D playerRB;

    public string playerShape;

    public string[] shapes;
    public Sprite[] shapesImages;

    public SpriteRenderer sr;

    private void Awake()
    {
        playerRB = GetComponent<Rigidbody2D>();
        int rand = Random.Range(0, shapes.Length);
        playerShape = shapes[rand];
        sr.sprite = shapesImages[rand];

    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            playerRB.velocity = Vector2.up * playerVelocity;
        }
    }

    public void ChangeShape(int shapeType)
    {
        playerShape = shapes[shapeType];
        sr.sprite = shapesImages[shapeType];
    }
}
