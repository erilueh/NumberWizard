using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{

	int max = 1000;
	int min = 1;
	int guess = 500;

	void Guess ()
	{
		print ("Is the number higher or lower than " + guess + "?");
		print ("Up arrow for higher, down for lower, return for equal");
	}

	// Use this for initialization
	void Start ()
	{
		print ("Welcome to Number Wizard");			
		print ("Pick a number in your mind but don't tell me!");


		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);

		Guess ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			min = guess;
			guess = (max + min) /2;
			Guess ();
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			max = guess;
			guess = (max + min) /2;
			Guess ();
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("I won!");
		} 

	}

}
