using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneTemplate;
using UnityEngine;

public class GestionCollision : MonoBehaviour
{
    // attribut

    private GestionJeu _gestionJeu;
    private bool _toucher;
    private float _timeToChange =4f; 
    private float _timeSinceChange = 0f;
    [SerializeField] private Material _couleur;

    private void Start()
    {
        _gestionJeu = FindObjectOfType<GestionJeu>();
        _toucher = false;
        
    }

    private void Update()
    {
        _timeSinceChange += Time.deltaTime;
        if(_timeSinceChange >= _timeToChange && _toucher == true)
        {
            gameObject.GetComponent<MeshRenderer>().material.color = _couleur.color;
            _toucher = false;
        }
            
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Touché!!!!");
            if (!_toucher)
            {
                _toucher = true;
                gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
                _gestionJeu.AugmenterPointage();
                _timeSinceChange = 0f;
                
            }
        }
    }
}
