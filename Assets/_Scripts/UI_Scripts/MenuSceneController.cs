/*
Khandker Faim Hussain
Thurs 12/10/2015
	Description:		Code from "Survival Shooter" and Assignment 03
	Revision History:	IDK!!!...
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuSceneController : MonoBehaviour 
{
	//PUBLIC INSTANCE VARIABLES
	//NOTE: These declared public "Button" objects will be referenced by the button's child objects which are the text objects in Unity
	//because I added button components on the text objects to make them look pretty...
	public Button btnStart;
	public Button btnInfo;
	public Button btnCheats;
	public Button btnExit;


//	// Use this for initialization
//	void Start () 
//	{
//	}
	
	//PUBLIC METHODS - CHANGING SCENES VIA BUTTON CLICKS (Button UI objects will call these methods "OnClick")
	public void MainLevelScene()
	{
		SceneManager.LoadScene ("MainLevelScene");
	}

	public void InfoScene()
	{
		SceneManager.LoadScene ("InfoScene");
	}

	public void CheatsScene()
	{
		SceneManager.LoadScene ("CheatsScene");
	}

	public void Exit()
	{
		Application.Quit ();
	}
}
