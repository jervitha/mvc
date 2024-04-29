using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSelection : MonoBehaviour
{

    public TankSpawner tankSpawner;
   public void BlueTankSlected()

    {
        Debug.Log("blue tank");
        tankSpawner.TankCreation(TankTypes.BlueTank);
        this.gameObject.SetActive(false);
    }


    public void GreenTankSelected()
    {
        tankSpawner.TankCreation(TankTypes.GreenTank);
        this.gameObject.SetActive(false);
    }

    public void RedTankSelected()
    {
        tankSpawner.TankCreation(TankTypes.RedTank);
       this.gameObject.SetActive(false);
    }
}
