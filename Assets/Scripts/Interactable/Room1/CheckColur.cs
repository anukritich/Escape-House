using UnityEngine;

public class ColorCheckManager : MonoBehaviour
{
    
  
    void Update()
    {
       
        if (Voilet.check==true && Blue.check == true && Indigo.check == true && 
            Green.check == true && Yellow.check == true
            && Orange.check == true && Red.check == true )
        {
            Debug.Log("All colours match");

        }
    }
}
