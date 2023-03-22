using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionRenard : MonoBehaviour
{
    private GestionJeu _gestionJeu;
    private bool _toucher;
    private float _timeToChange = 4f;
    private float _timeSinceChange = 0f;
    [SerializeField] private Material _couleur;
    // Start is called before the first frame update
    void Start()
    {
        _gestionJeu = FindObjectOfType<GestionJeu>();
        _toucher = false;
    }

    // Update is called once per frame
    void Update()
    {
        _timeSinceChange += Time.deltaTime;
        if (_timeSinceChange >= _timeToChange && _toucher == true)
        {
            gameObject.GetComponent<SkinnedMeshRenderer>().material.color = _couleur.color;
            _toucher = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

        Debug.Log("Touch�!!!!");

        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Touch�!!!!");
            if (!_toucher)
            {
                _toucher = true;
                gameObject.GetComponent<SkinnedMeshRenderer>().material.color = Color.red;
                _gestionJeu.AugmenterPointage();
                _timeSinceChange = 0f;

            }
        }
    }
}
