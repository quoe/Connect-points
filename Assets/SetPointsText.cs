using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPointsText : MonoBehaviour {
	private UnityEngine.UI.Text tm;
	// Use this for initialization
	void Start () {
		tm = GetComponent<UnityEngine.UI.Text>();
		tm.text = "";
	}

	public void SetText(string S1, string S2) {
		tm.text += S1 + "->" + S2 + "\n";
	}
	// Update is called once per frame
	void Update () {
		
	}
}
