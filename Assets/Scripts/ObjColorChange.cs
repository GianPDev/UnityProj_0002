using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjColorChange : MonoBehaviour {
	public ObjColorChange()
	{

	}

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log(gameObject.name + " color set to" + setColor(Color.red));
            //gameObject.GetComponent<Renderer>().material.color = ""; //Find a way to set color by hex
        }
	    if(Input.GetKeyDown(KeyCode.G))
        {
            Debug.Log(gameObject.name + " color set to" + setColor(Color.green));
        }
	    if(Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log(gameObject.name + " color set to" + setColor(Color.blue));
        }
	}

	public Color setColor(Color color)
	{
		gameObject.GetComponent<Renderer>().material.color = color;
		return color;
	}

	static public Color addRGB(Color color, float red, float green, float blue)
	{
		Color _color = color;
		
		_color.r += red;
		_color.g += green;
		_color.b += blue;

		return _color;
	}
}
