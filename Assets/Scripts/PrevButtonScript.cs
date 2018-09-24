using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class PrevButtonScript : MonoBehaviour, IVirtualButtonEventHandler
{

    private GameObject virtualButtonObject;
    private GameObject magazine2;
    public Material magazineCoverMat;
    public Material magazinePage1Mat;
    public Material magazinePage2Mat;
    public Material magazinePage3Mat;
    public Material magazinePage4Mat;
    Material currentMaterial;
    public AudioSource audioSource;

    void Start()
    {
        virtualButtonObject = GameObject.Find("PreviousButton");
        virtualButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        magazine2 = GameObject.Find("Magazine2Plane");
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button Pressed for Prev Button");
        audioSource.Play();
        currentMaterial = magazine2.GetComponent<Renderer>().material;
        string materialName = currentMaterial.name;
        if (materialName.Equals("MagazineCoverMat (Instance)"))
        {
            magazine2.GetComponent<Renderer>().material = magazinePage4Mat;
        }
        if (materialName.Equals("MagazinePage1Mat (Instance)"))
        {
            magazine2.GetComponent<Renderer>().material = magazineCoverMat;
        }
        if (materialName.Equals("MagazinePage2Mat (Instance)"))
        {
            magazine2.GetComponent<Renderer>().material = magazinePage1Mat;
        }
        if (materialName.Equals("MagazinePage3Mat (Instance)"))
        {
            magazine2.GetComponent<Renderer>().material = magazinePage2Mat;
        }
        if (materialName.Equals("MagazinePage4Mat (Instance)"))
        {
            magazine2.GetComponent<Renderer>().material = magazinePage3Mat;
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button Released for Previous Button.");
    }


 


}

