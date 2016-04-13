using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	int max;
	int min;
	int guess;
	
	// Use this for initialization
	void Start () 
	{
		StartGame();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.UpArrow))
		{
			//print ("Up arrow pressed");
			min = guess+1;
			guess = (min+max)/2;
			if(min<=max) NextGuess();
			else
			{
				print ("Don't try cheating me , you dirty cheater !");
				StartGame();
			}
		}
		
		else if(Input.GetKeyDown(KeyCode.DownArrow))
		{
			//print ("Down arrow pressed");
			max = guess-1;
			guess = (min+max)/2;
			if(min<=max) NextGuess();
			else
			{
				print ("Don't try cheating me , you dirty cheater !");
				StartGame();
			}
		}
		
		else if(Input.GetKeyDown(KeyCode.Return))
		{
			print ("I won.");
			StartGame();
		}
	}
	
	void StartGame ()
	{
		print ("===============================================================");
		
		max = 1000;
		min = 1;
		guess = (max+min)/2;
		
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head but don't tell me.");
		
		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);
		
		print ("Is the number higher or lower than " + guess + "?");
		print ("UP arrow for higher, DOWN arrow for lower, RETURN for equals");
	}
	
	void NextGuess()
	{
		print ("Is the number higher or lower than " + guess + "?");
		//print ("min = " + min + ", max = " + max);
		print ("UP arrow for higher, DOWN arrow for lower, RETURN for equals");
	}
}
