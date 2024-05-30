using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlquilerVehiculos : MonoBehaviour
{
    public GameObject[] vehiculos;
    int currentIndex = -1;
    int vehiculoRandom;

    // Start is called before the first frame update
    void Start()
    {
        ResetearVehiculos();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            deactivateAll();
            vehiculoRandom = Random.Range(0, vehiculos.Length);
            vehiculos[vehiculoRandom].SetActive(true);
        }   
    }

    void ResetearVehiculos()
    {
        deactivateAll();
        activateByIndex();
    }
    void deactivateAll()
    {
        for (int i = 0; i < vehiculos.Length; i++)
        {
            vehiculos[i].SetActive(false);
        }
    }
    void activateByIndex()
    {
        currentIndex++;
        vehiculos[currentIndex].SetActive(true);
    }
}
