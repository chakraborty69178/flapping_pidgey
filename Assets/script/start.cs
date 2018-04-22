using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class start : MonoBehaviour {
	public bool TestMode=false;
	bool OnstartingB=false;
	bool OnMainMenuB=false;
	bool OnQuitBool=false;

	public void Onstarting()
	{	/*if (Advertisement.IsReady())
		{
			Advertisement.Show();

		}*/
		OnstartingB = true;
	}
	public void OnQuit()
	{	/*if (Advertisement.IsReady())
		{
			Advertisement.Show();
			OnQuitBool = true;
		}*/
		OnQuitBool = true;

	}
	public void OnMainMenu()

	{
		/*if (Advertisement.IsReady())
		{
			Advertisement.Show();

		}*/
		OnMainMenuB = true;

	}
	public void Start()
	{
	//	Advertisement.Initialize ("1245569",TestMode);
	}
	public void ShowAd()
	{
		///if (Advertisement.IsReady())
		//{
			//Advertisement.Show();
		//}
	
	}
	void Update ()
	{
		if (OnstartingB/*&&Advertisement.isShowing==false*/) {
			int x;
			x = Random.Range (1, 100);
			if(x>=25&&x<50||x>75)
				SceneManager.LoadScene ("Left");
			if(x<25||x>=50&& x<=75)
				SceneManager.LoadScene ("Left 1");
			OnstartingB = false;
		}
		if (OnMainMenuB/*Advertisement.isShowing==false*/) {
			SceneManager.LoadScene ("start");
			OnMainMenuB = false;
		}
		if (OnQuitBool/*Advertisement.isShowing==false*/) {
		
			Application.Quit ();
			OnQuitBool = false;
		}

	}

}
