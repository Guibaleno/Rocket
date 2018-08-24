using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptRocket : MonoBehaviour {
    public Rigidbody CarRigidBody;
    [SerializeField] public float ForceUpward = 200;
    [SerializeField] public float ForceTrust = 200;
    // Use this for initialization
    void Start () {
        CarRigidBody = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        ManageVerticalInput();
        ManageHorizontalInput();
    }
    private void ManageVerticalInput()
    {
        if (Input.GetAxis("Jump") > 0)
        {
            CarRigidBody.AddRelativeForce(new Vector3(0, ForceUpward, 0));
        }
        else if (Input.GetAxis("Jump") < 0)
        {
            CarRigidBody.AddRelativeForce(new Vector3(0, -ForceUpward, 0));
        }
    }
    private void ManageHorizontalInput()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            CarRigidBody.AddForceAtPosition(new Vector3(0, 0, ForceTrust), new Vector3());
            
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            CarRigidBody.AddForceAtPosition(new Vector3(0, 0, -ForceTrust), new Vector3());
        }
    }
}
