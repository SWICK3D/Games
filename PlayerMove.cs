using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float Speed;
    public float Boost;

	// Update is called once per frame
	void FixedUpdate ()
    {

        transform.Translate(Speed * Input.GetAxis("Horizontal") * Time.deltaTime, 0, Speed * Input.GetAxis("Vertical") * Time.deltaTime);

    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
