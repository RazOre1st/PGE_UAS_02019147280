using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{

	public GameObject MenuPanel;
	public GameObject ControlPanel;

	void Start()
	{
		MenuPanel.SetActive(true);
		ControlPanel.SetActive(false);
	}

	void Update()
	{

	}

	public void StartButtonClicked()
	{
		Application.LoadLevel("Gameplay");
	}
	public void ControlButtonClicked()
	{
		MenuPanel.SetActive(false);
		ControlPanel.SetActive(true);
	}
	public void ExitButtonClicked()
	{
		Application.Quit();
	}
	public void BackButtonClicked()
	{
		MenuPanel.SetActive(true);
		ControlPanel.SetActive(false);
	}
}
