using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float _vitesseRotationY = 0.5f;

    void Update()
    {
        transform.Rotate(0f, _vitesseRotationY, 0f);
    }
}
