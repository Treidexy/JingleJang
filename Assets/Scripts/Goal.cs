using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal: MonoBehaviour
{
	void OnCollisionEnter2D(Collision2D hit)
	{
		if (hit.collider.tag == "Player")
			hit.collider.GetComponent<Player>().Win();
		if (hit.collider.tag == "Player Dash")
			hit.collider.transform.parent.GetComponent<Player>().Win();
	}
}
