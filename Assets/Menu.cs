using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Menu : MonoBehaviour {

	public Canvas quitMenu;;
	public Button btnLevel;
	public Button btnExit;
	/** Obiekt menu.*/
	private Canvas manuUI;
	
	void Start (){
	
		Time.timeScale = 0;
		Cursor.visible = manuUI.enabled;
		Cursor.lockState = CursorLockMode.Confined;//Odblokowanie kursora myszy.
	}

	
	public void bExit() {
		quitMenu.enabled = true; //Uaktywnienie meny z pytaniem o wyjście
		btnLevel.enabled = false; //Deaktywacja przycsiku 'Start'.
		btnExit.enabled = false; //Deaktywacja przycsiku 'Wyjście'.
	}

	//Metoda wywoływana podczas udzielenia odpowiedzi przeczącej na pytanie o wyjście z gry.
	public void bNo(){
		quitMenu.enabled = false; 
		btnLevel.enabled = true;
		btnExit.enabled = true; 
	}

	//Metoda wywoływana przez przycisk uruchomienia gry 'Play Game'
	public void bPlay (){
		//Application.LoadLevel (0); //this will load our first level from our build settings. "1" is the second scene in our game	
		manuUI.enabled = false; 
		Time.timeScale = 1;
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
		
	}

	public void bYes () {
		Application.Quit(); 
		
	}
