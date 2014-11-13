using UnityEngine;
using System.Collections;

public class BuildOnTop : MonoBehaviour
{
	public Transform brick;
	void Start ()
	{

	}

	
	void OnMouseDown ()
	{
		Vector3 pos = transform.position;
		pos.y+=1;
		Instantiate(brick, pos, Quaternion.identity);
	}
}