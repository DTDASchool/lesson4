using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouvement : MonoBehaviour
{
	public float mouvSpeed;
	public float force;
	public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
	

    // Update is called once per frame
    void Update()
    {
        float tempV = Input.GetAxis ("Vertical");
		float tempH = Input.GetAxis ("Horizontal");
		//Debug.Log(transform.position);
		
		transform.position = new Vector3 (transform.position.x + tempH * Time.deltaTime * mouvSpeed, transform.position.y, transform.position.z + tempV * Time.deltaTime * mouvSpeed);
           
        if(Input.GetKeyDown("space"))
		{
			rb.AddForce(transform.up*force);
		}
    }
}
