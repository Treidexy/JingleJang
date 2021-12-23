using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava: MonoBehaviour
{
	void OnCollisionEnter2D(Collision2D hit)
	{
		if (hit.collider.tag == "Player")
			hit.collider.GetComponent<Player>().Lose();
	}
}
