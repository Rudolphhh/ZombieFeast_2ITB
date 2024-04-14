using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    public GameObject levelButtonPrefab; // Reference to the LevelButton prefab
    public Transform buttonParent; // Reference to the parent object under which buttons will be created
    public GridLayoutGroup gridLayoutGroup; // Reference to the Grid Layout Group component

    private string[] availableLevels = { "cerveneKostky", "zadek" };

    // Start is called before the first frame update
    void Start()
    {
        CreateLevelButtons();
        // vytvoøit list dostupných levelù
        // pro každý level vytvoøit button
        // na každém LevelButtonu zavolat SetData s názvem levelu
        // Pøidat LevelButton jako prefab
        // Pøidat všechny level buttony jako childy pro grid layout
    }

    void CreateLevelButtons()
    {
        foreach (string levelName in availableLevels)
        {
            GameObject buttonGO = Instantiate(levelButtonPrefab, buttonParent); // Instantiate button from prefab
            LevelButton levelButton = buttonGO.GetComponent<LevelButton>(); // Get LevelButton component
            if (levelButton != null)
            {
                levelButton.SetData(levelName); // Set data for the button
            }
        }

       
        
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
