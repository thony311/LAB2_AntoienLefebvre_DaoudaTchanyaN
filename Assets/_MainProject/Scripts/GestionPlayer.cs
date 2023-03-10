using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionPlayer : MonoBehaviour
{
    // Attributs
    [SerializeField] private float _vitesse = 1000;
    [SerializeField] private float _vitesseRotation = 10;
    private bool _finJeu = false;
    private Rigidbody _rb;
    private float _timeStart;
    private bool _debutJeu;

    // Méthode privéees
    private void Start()
    {
        // Position de départ du joueur
        this.transform.position = new Vector3(-34f, 1.01f, -47f);
        _rb = GetComponent<Rigidbody>();
        _debutJeu= false;
    }


    private void FixedUpdate()
    {
        if (!_finJeu)
            MouvementJoueur();
    }

    public void finDeJeu()
    {
        _finJeu = true;
    }

    public float GetTimeStart()
    {
        return _timeStart;
    }


    private void MouvementJoueur()
    {
        if(_debutJeu == false && Input.anyKey)
        {
            _timeStart = Time.time;
            _debutJeu = true;
            Debug.Log("c'est parti!");
        }
        float positionX = Input.GetAxis("Horizontal");
        float positionZ = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(positionX, 0f, positionZ);
        direction.Normalize();
        _rb.velocity = direction * Time.fixedDeltaTime * _vitesse;
        if(direction != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(direction,Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation,toRotation,_vitesseRotation * Time.deltaTime);
        }
    }

}
