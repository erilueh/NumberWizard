using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		print ("Welcome to Number Wizard");			
		print ("Pick a number in your mind but don't tell me!");

		int max = 1000;
		int min = 1;

		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);

		print ("Is the number higher or lower than 500?");
		print ("Up arrow for higher, down for lower, return for equal");
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			print ("up arrow pressed");
		} 
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			print ("down arrow pressed");
		}
	}
}
