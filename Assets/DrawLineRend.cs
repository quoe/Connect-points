using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLineRend : MonoBehaviour {
	LineRenderer L;
	public Vector3 PosStart;
	public Vector3 PosEnd;
	void Start () {
		L = GetComponent<LineRenderer> ();
		Vector3[] Vect = new Vector3[2];
		PosStart = transform.position;
		PosEnd = PosStart;
		Vect.SetValue (PosStart, 0);
		Vect.SetValue (PosEnd, 1);
		//L.SetPositions(Vect);
	}
		
	// Update is called once per frame
	void Update () {
		//LineRenderer L = GetComponent<LineRenderer> ();
		Vector3 Zero = new Vector3(0, 0, 0);
		if ((PosStart == Zero) & (PosEnd == Zero)) {
			return;
		}
		Vector3[] Vect = new Vector3[2];
		Vect.SetValue (PosStart, 0);
		Vect.SetValue (PosEnd, 1);
		L.SetPositions(Vect);
	}
}
