using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangementSenseRotation : MonoBehaviour
{
    [SerializeField] private List<GameObject> list = new List<GameObject>();
    [SerializeField] private string _tag;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == _tag)
        {
            Debug.Log("nice you got it");
            
        }
    }
}
