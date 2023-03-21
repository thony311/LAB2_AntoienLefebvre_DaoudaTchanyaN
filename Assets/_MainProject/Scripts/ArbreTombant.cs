using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArbreTombant : MonoBehaviour
{
    [SerializeField] private float _vitesseRotationX = 0.5f;
    

    void Update()
    {
        transform.Rotate(_vitesseRotationX, 0f, 0f);

    }

    public void ChangerSenseRotation()
    {
        _vitesseRotationX*= -1;
    }

}
