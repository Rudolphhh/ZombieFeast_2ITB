using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // vytvo�it list dostupn�ch level�
        // pro ka�d� level vytvo�it button
        // na ka�d�m LevelButtonu zavolat SetData s n�zvem levelu
        // P�idat LevelButton jako prefab
        // P�idat v�echny level buttony jako childy pro grid layout
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
