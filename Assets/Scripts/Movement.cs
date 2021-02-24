using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float thrustPower = 20f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessThrust();
    }

    void ProcessThrust(){
        
        if(Input.GetKey(KeyCode.Space)){
            Debug.Log("Space pressed");
            rb.AddRelativeForce(0,thrustPower*Time.deltaTime,0);
        }
        
        
        float axisHoriz = Input.GetAxis("Horizontal");
        if(axisHoriz > 0f){
            rb.freezeRotation = true;
            transform.Rotate(0, 0, -1);
            rb.freezeRotation = false;
        }else if(axisHoriz < 0f){
            rb.freezeRotation = true;
            transform.Rotate(0, 0, 1);
            rb.freezeRotation = false;
        }
    }
}
