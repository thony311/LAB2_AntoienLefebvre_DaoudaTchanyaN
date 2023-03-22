using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PiegeRenard : MonoBehaviour
{
    [SerializeField] private float _vitesse = 10;
    private RaycastHit Hit;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector3.forward * _vitesse * Time.deltaTime);

        if(Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward),out Hit, 1))
         {
            transform.Rotate(0f,Random.Range(90f, 180f),0f);
            
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

        //transform.Rotate(Vector3.up * Random.Range(90, 180));

        
    }

}
