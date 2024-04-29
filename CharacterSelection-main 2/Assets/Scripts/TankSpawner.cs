using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    public TankView tankView;

    public void Start()
    {
        TankCreation();

    }

    private void TankCreation()
    {
        TankModel tankModel= new TankModel(30,20);
        TankController tankController = new TankController(tankModel,tankView);
    }
}
