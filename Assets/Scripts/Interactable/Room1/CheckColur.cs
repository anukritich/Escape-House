using UnityEngine;

public class ColorCheckManager : MonoBehaviour
{
    //public Yellow yellowScript;
    //public Voilet voiletScript;
    //public Indigo indigoScript;
    //public Blue blueScript;
    //public Green greenScript;
    //public Orange orangeScript;
    //public Red redScript;

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
