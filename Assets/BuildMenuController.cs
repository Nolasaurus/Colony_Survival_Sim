using UnityEngine;

public class BuildMenuController : MonoBehaviour
{
    public GameObject buildMenuPanel; // Reference to the build menu panel

    public void OpenBuildMenu()
    {
        buildMenuPanel.SetActive(true);
    }

    public void CloseBuildMenu()
    {
        buildMenuPanel.SetActive(false);
    }
	
	public void ToggleBuildMenu()
	{
    buildMenuPanel.SetActive(!buildMenuPanel.activeSelf);
	}
}
