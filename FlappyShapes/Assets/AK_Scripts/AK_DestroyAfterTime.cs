using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_DestroyAfterTime : MonoBehaviour
{
    public float timer;

    private void Start()
    {
        Destroy(gameObject, timer);
    }
}
