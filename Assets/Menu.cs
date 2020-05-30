using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using Cursor = UnityEngine.Cursor;

public class Menu : MonoBehaviour {

	public Canvas quitMenu;
//	public Button btnLevel;
//	public Button btnExit;
	private Canvas menuUI;
	public Canvas selectLevel;
	
	void Start (){
	   menuUI = (Canvas)GetComponent<Canvas>();//Pobranie menu główn
	   selectLevel = (Canvas)GetComponent<Canvas>();//Pobranie menu główn
	   Time.timeScale = 0;
//	   btnLevel = btnLevel.GetComponent<Button> ();//Ustawienie przycisku uruchomienia gry.
//	   btnExit = btnExit.GetComponent<Button> ();//Ustawienie przycisku wyjścia z gry.
		Cursor.visible = menuUI.enabled;
		Cursor.lockState = CursorLockMode.Confined;//Odblokowanie kursora myszy.
	}

	
	public void bExit() {
		quitMenu.gameObject.SetActive(true); 
		menuUI.gameObject.SetActive(false); 
//		btnLevel.enabled = false; 
//		btnExit.enabled = false; 
	}

	//Metoda wywoływana podczas udzielenia odpowiedzi przeczącej na pytanie o wyjście z gry.
	public void bNo(){
		quitMenu.gameObject.SetActive(false);
		menuUI.gameObject.SetActive(true);
		
//		btnLevel.enabled = true;
//		btnExit.enabled = true; 
	}

	//Metoda wywoływana przez przycisk uruchomienia gry 'Play Game'
	public void bSelectLevel (){
		
		menuUI.gameObject.SetActive(false);
		selectLevel.gameObject.SetActive(true);
		SceneManager.LoadScene(1, LoadSceneMode.Single);
		
		//Time.timeScale = 1;
		//Cursor.visible = false;
		//Cursor.lockState = CursorLockMode.Locked;

	}

	public void bYes () {
		Application.Quit(); 
		
	}}
