/*
	Author:			Khandker Faim Hussain
	Date:			Tues, 02/05/2017
	Description:	This script is only used for one method and that is to go back to the "MenuScene". 
					This script is used in both the "InfoScene" and the "CheatsScene"
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackToMenuController : MonoBehaviour 
{
	//PUBLIC INSTANCE VARIABLES
	//NOTE: These declared public "Button" objects will be referenced by the button's child objects which are the text objects in Unity
	//because I added button components on the text objects to make them look pretty...
	public Button btnBack;

	//PUBLIC METHOD - Goes back to the "MenuScene"
	public void BackToMenuScene()
	{
		SceneManager.LoadScene ("Menu_Scene");
	}
}
