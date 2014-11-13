using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	public int speed;
	public float blockdelay = 0.5f;
	public Transform brick;
	//private bool blocksPlaced = false;
	bool blocksPlaced;

	// Use this for initialization
	void Start(){
		/*
		for (int z = -5; z < 5; z++) {
			for (int x = -5; x < 5; x++) {
				Instantiate(brick, new Vector3(0.5f*x,0.1f,0.5f*z), Quaternion.identity);
			}
		}*/
		}

	IEnumerator PlaceBlock()
	{	

		blocksPlaced = true;
		yield return new WaitForSeconds(blockdelay);
		blocksPlaced = false;
	}
	
	void Update()
	{


		if(Input.GetMouseButton(1)==true && !blocksPlaced)
		{
			print ("Click!");
			Instantiate(brick, new Vector3(0, 3, 0), Quaternion.identity);
			StartCoroutine(PlaceBlock());
		}
	}
	void LateUpdate() {

			//var hit =  RaycastHit;
			//Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			//print (ray);
			//print (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition)));
			// vigtig print (Camera.main.ScreenPointToRay(Input.mousePosition));
			//	print ("hej");
			//	print (Camera.main.ScreenPointToRay(Input.mousePosition));
			//	print (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition)));
			//camera.ScreenToWorldPoint(Vector3)
			
			//Vector3 p = camera.ScreenToWorldPoint(vec);
			//Gizmos.color = Color.yellow;
			//Gizmos.DrawSphere(p, 0.1F);
		//print(Input.mousePosition);
		//vector3 position = Input.mousePosition;
		//float movehorizontal = Input.GetAxis("Horizontal");
		float movevertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (0.0f, 0.0f,movevertical);
		transform.Translate(movement * Time.deltaTime);



		if (Input.mousePosition.x < 120)
				transform.RotateAround (Vector3.zero, Vector3.up, speed * Time.deltaTime);

		if (Input.mousePosition.x > Screen.width-120)
			transform.RotateAround (Vector3.zero, -Vector3.up, speed * Time.deltaTime);
	}
}
