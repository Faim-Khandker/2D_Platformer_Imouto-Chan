/*
	Author:			Khandker Faim Hussain
	Date:			Tues, 02/05/2017
	Description:	Script is only used for the Canvas GameObject in "MenuScene" 
					and is used to call scenes when player clicks on the buttong gameobjects
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
	
	//PUBLIC METHODS - CHANGING SCENES VIA BUTTON CLICKS (Button UI objects will call these methods "OnClick")
	public void StartMainLevel()
	{
		SceneManager.LoadScene ("Level01_Main_Scene");
	}

	public void GoToInfoScene()
	{
		SceneManager.LoadScene ("Info_Scene");
	}

	public void GoToCheatsScene()
	{
		SceneManager.LoadScene ("Cheats_Scene");
	}

	public void Exit()
	{
		Application.Quit ();
	}
}
