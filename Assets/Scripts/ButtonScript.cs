using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class ButtonScript : MonoBehaviour, IVirtualButtonEventHandler {

    private GameObject virtualButtonObject;
    private GameObject magazine2;
    public Material magazineCoverMat;
    public Material magazinePage1Mat;
    public Material magazinePage2Mat;
    public Material magazinePage3Mat;
    public Material magazinePage4Mat;
    Material currentMaterial;
    public AudioSource audioSource;

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button Pressed");
        //cube.transform.Rotate(new Vector3(0, Time.deltaTime * 500, 0));
        //cube.GetComponent<Renderer>().material = material1;
        //material1.color = Color.red;
        audioSource.Play();
        currentMaterial = magazine2.GetComponent<Renderer>().material;
        string materialName= currentMaterial.name;
        //Debug.Log("name is " + materialName);
        if (materialName.Equals("MagazineCoverMat (Instance)"))
        {
            Debug.Log("Inside Magazine Cover Material");
            magazine2.GetComponent<Renderer>().material = magazinePage1Mat;
        }
        if (materialName.Equals("MagazinePage1Mat (Instance)"))
        {
            magazine2.GetComponent<Renderer>().material = magazinePage2Mat;
        }
        if (materialName.Equals("MagazinePage2Mat (Instance)"))
        {
            magazine2.GetComponent<Renderer>().material = magazinePage3Mat;
        }
        if (materialName.Equals("MagazinePage3Mat (Instance)"))
        {
            magazine2.GetComponent<Renderer>().material = magazinePage4Mat;
        }
        if (materialName.Equals("MagazinePage4Mat (Instance)"))
        {
            magazine2.GetComponent<Renderer>().material = magazineCoverMat;
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button Released");
    }


    void Start () {
        virtualButtonObject = GameObject.Find("NextButton");
        virtualButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        magazine2 = GameObject.Find("Magazine2Plane");
        //material1 = cube.GetComponent<Renderer>().material;

    }


}
