using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonePiege : MonoBehaviour
{
    // attribut

    private bool _estActiver = false;
    private Rigidbody _rb;
    [SerializeField] private float _intensiteForce;
    [SerializeField] private List<GameObject> _listePiege = new List<GameObject>();
    private List<Rigidbody> _listeRB = new List<Rigidbody>();

    private void Start()
    {
        foreach (var piege in _listePiege)
        {
            _listeRB.Add(piege.GetComponent<Rigidbody>());
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!_estActiver && other.gameObject.tag == "Player")
        {
            foreach (var rb in _listeRB)
            {
                rb.useGravity = true;
                rb.AddForce(Vector3.down * _intensiteForce);
            }

            //Debug.Log("TU AS ACTIVER MA CARTE PIEGE!!!!!!!!!!!!!!!!");
            //_estActiver = true;
            //_rb.useGravity = true;
            //Vector3 direction = new Vector3(0f,-1f,0f);
            //_rb.AddForce(Vector3.down * _intensiteForce);
        }
    }
}
