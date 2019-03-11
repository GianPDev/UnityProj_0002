using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingOtherComponents : MonoBehaviour {

	public GameObject otherGameObject;
	private ObjColorChange objColorChange;
	private ObjColorChange otherObjColorChange;
	[SerializeField]private Color color;

	public UsingOtherComponents(Color Color)
	{
		color = Color;
	}

	public UsingOtherComponents()
	{
		color = Color.red;
	}
	void Awake()
	{
		objColorChange = GetComponent<ObjColorChange>();
		Debug.Log(objColorChange.name + " attached to " + this.name);
		otherObjColorChange = otherGameObject.GetComponent<ObjColorChange>();
		Debug.Log(otherObjColorChange.name + " attached to " + this.name);
	}

	// Use this for initialization
	void Start () 
	{
		Debug.Log(this.name + " Color: " + objColorChange.setColor(color));
		color = ObjColorChange.addRGB(color, 0.5f, 0.5f, 0.5f);
		Debug.Log(otherObjColorChange.name + " Color: " + otherObjColorChange.setColor(color));
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
