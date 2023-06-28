using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //This creates a reference to each car
    [SerializeField] private Car ford;
    [SerializeField] private Car toyota;
    [SerializeField] private Car audi;
    //This makes an ARRAY
    [SerializeField] private Car[] allRacecars;
    //This makes a list
    [SerializeField] private List<Car> allRacecarsList = new List<Car>();

    private void Start()

    // Output names of all Cars at Start
    {
        //For ARRAY:
        Debug.Log(allRacecars.Length);
        Debug.Log(allRacecars[2].name);

        //For LIST
        Debug.Log(allRacecarsList.Count);
        Debug.Log(allRacecarsList[2].name);

        CheckWhichCarIsCrashed();

    }

    private void CheckWhichCarIsCrashed()
    {
        //use for LOOP
        for (int selectedCarIndex = 0; selectedCarIndex < allRacecars.Length; selectedCarIndex++)
        {
            if (allRacecars[selectedCarIndex].isCrashed == true)
            {
                //reference whole index
                Debug.Log("CRASHED" + selectedCarIndex);
                //reference specfific car
                Debug.Log("a car has crashed: [" + allRacecars[selectedCarIndex].name);
            }
        }
    }

    //this how you make a button
    public void HelloWorldButton()
    {
        Debug.Log("HelloWorld");
    }
}

        
    

