using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonData : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Points myObject = new Points();
		myObject.timeElapsed = 47.5f;
		myObject.playerName = "Dr Charles Francis";
		string json = JsonUtility.ToJson(myObject);
		JsonUtility.FromJsonOverwrite(json, myObject);
		myObject = JsonUtility.FromJson<Points>(json);
		//{"level":1,"timeElapsed":47.5,"playerName":"Dr Charles Francis"}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
	
[System.Serializable]
public class Points
{
	public Vector3[] Pos;
	public float timeElapsed;
	public string playerName;
}
	


