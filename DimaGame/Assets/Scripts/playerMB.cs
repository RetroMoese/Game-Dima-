using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMB : MonoBehaviour
{

    
      Rigidbody rigidbody;
     [SerializeField] private float _speed;
     
    // Start is called before the first frame update
    void Start()
    {
       rigidbody= GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
         float horizontalInput=Input.GetAxis("Horizontal");
         float vetricalInput=Input.GetAxis("Vertical");
        Vector3 directionVector= new Vector3(vetricalInput,0,horizontalInput);
        rigidbody.velocity=  Vector3.ClampMagnitude(directionVector,1)* _speed;
        
    }
}
