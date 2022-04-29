using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiseasesManager : MonoBehaviour,IDiseaseStatus
{
    public AnimalInfectiousDiseases animalInfectiousDiseases;

    void Start()
    {
        animalInfectiousDiseases.animalIsIll = false;
        
    }
    void Update()
    {
        
    }
    void CheckAnimalInfo()
    {
        print("");
    }
    void IDiseaseStatus.CheckAnimal()
    {
        
    }

}
