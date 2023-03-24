using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GesionBateau : MonoBehaviour
{
    [SerializeField] private float _vitesse = -0.2f;
    private Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        direction = new Vector3(_vitesse, 0f, 0f);
        
    }

    // Update is called once per frame
    void Update()
    {
        //this.gameObject.GetComponent<Rigidbody>().AddForce(direction);
        transform.Translate(direction);
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        _vitesse *= -1;
        Debug.Log(_vitesse);
        transform.Rotate(0f, 180f, 0f);
        
    }

}
