using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using Cursor = UnityEngine.Cursor;

public class Menu : MonoBehaviour
{

	public Canvas quitMenu;
	private Canvas menuUI;
	public Canvas creditUI;
	public Canvas selectLevel;
	
	void Start (){
	   menuUI = (Canvas)GetComponent<Canvas>();
	  Cursor.visible = menuUI.enabled;
	}
	public void bExit() {
		quitMenu.gameObject.SetActive(true); 
		menuUI.gameObject.SetActive(false); 
	}
	public void bNo(){
		quitMenu.gameObject.SetActive(false);
		menuUI.gameObject.SetActive(true);
	}

	public void bSelectLevel (){
	
	selectLevel.gameObject.SetActive(true);
	Debug.Log("selectLevel");
	menuUI.gameObject.SetActive(false);
	
	}
	public void bYes () {
		Application.Quit();
	}

	public void bKross()
	{
		menuUI.gameObject.SetActive(true); 
		selectLevel.gameObject.SetActive(false);
		creditUI.gameObject.SetActive(false);
	}
	public void bCredit(){
	creditUI.gameObject.SetActive(true);
	menuUI.gameObject.SetActive(false);
	}


}
