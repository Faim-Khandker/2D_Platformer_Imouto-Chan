/*
	Author:			Khandker Faim Hussain
	Date:			Thurs, 04/05/2017
	Description:	This script is only used when the player falls to their "death"
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathTrigger : MonoBehaviour 
{
	//OnTrigger Methods
	void OnTriggerEnter2D(Collider2D other)
	{
		//Checks to ensure the object with the correct tag is touching the object that is attached with this script
		if(other.gameObject.CompareTag("Player"))
		{
			//NOTE: DEBUGGING PURPOSE FOR NOW:
			SceneManager.LoadScene("Level01_Main_Scene");
		}
	}
}
