using UnityEngine;
using System.Collections;

public class control : MonoBehaviour 
{


	public Transform movee;
	public Transform target;
	public float xSmooth = 0f;
	public float ySmooth = 0f;
	public int mouseBtn = 0;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		

		if (Input.GetMouseButtonDown(mouseBtn))
		{
			Vector3 clickPosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			clickPosition.z = transform.position.z;
			target.transform.position = clickPosition;
		}
		

		float targetX = Mathf.Lerp(transform.position.x, target.transform.position.x, xSmooth * Time.deltaTime);
		//float targetY = Mathf.Lerp(transform.position.y, target.transform.position.y, ySmooth * Time.deltaTime);
		transform.position = new Vector3(targetX, transform.position.y, transform.position.z);

	}

}
	