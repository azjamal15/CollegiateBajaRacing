using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class ButtonOptions : MonoBehaviour {
	public void PlayGame () { 
		SceneManager.LoadScene(1);
	}

	public void Menu() { 
		SceneManager.LoadScene (0); 
	}

	public void Info1 () { 
		SceneManager.LoadScene (2);
	}

	public void Info2 () { 
		SceneManager.LoadScene (3); 
	}

	public void RestartGame() { 
		SceneManager.LoadScene (1);
	}

	public void Controls() { 
		SceneManager.LoadScene (5);
	}

	public void ExitGame() { 
		SceneManager.LoadScene (4);
	}


}
