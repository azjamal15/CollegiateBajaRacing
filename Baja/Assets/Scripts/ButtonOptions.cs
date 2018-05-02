using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class ButtonOptions : MonoBehaviour {

	/* Button Options for Main Menu */

	public void PlayGame () { 
		SceneManager.LoadScene(1);
	}



	public void Info1 () { 
		SceneManager.LoadScene (2);
	}
		
	public void RestartGame() { 
		SceneManager.LoadScene (1);
	}

	public void Controls() { 
		SceneManager.LoadScene (5);
	}

	public void Credits() { 
		SceneManager.LoadScene (4);
	}

	public void ExitGame() { 
		//SceneManager.LoadScene (4);
		Application.Quit();
	}


	/* Button Options for outside of Main */ 

	public void Menu() { 
		SceneManager.LoadScene (0); 
	}


}
