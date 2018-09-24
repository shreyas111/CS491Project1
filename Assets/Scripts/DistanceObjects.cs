using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class DistanceObjects : MonoBehaviour {

    public GameObject object1;
    public GameObject object2;
    public Vector3 pos1;
    public Vector3 pos2;
    float distance;
    bool detected;
    bool detected1;
    private GameObject burger;
    private GameObject cake;
    //private GameObject croissant;
    private GameObject donut;
    //private GameObject chips;
    private GameObject quadLeft;
    //private MeshRenderer quadLeftMeshRendrer;
    private GameObject quadRight;
    private GameObject cerealBoxPlane;
    private GameObject PTMedievalPeasant;
    private GameObject knight;
    //private GameObject Lumberjack3;
    //private GameObject Lumberpack;
    private GameObject PTMedievalTree;
    private GameObject cart;
    private GameObject cartAd;
    private GameObject cartWheels;
    private GameObject PTMedievalRock;
    private GameObject taco;
    private GameObject egg;
    private GameObject drink;
    private GameObject omelette;

    private GameObject knightMat;
    //private GameObject lumberjackMat3;

    //private GameObject cerealBox1Button;
    

    private bool inproxmity;
    public AudioSource enteredSoundSource;
    public AudioSource completedSoundSource;
    public bool playSound=false;
    public bool playCompletedSound = false;

    public Text cerealBox1CaloriesText;
    
    // Use this for initialization
    void Start () {

        burger = GameObject.Find("Burger");
        cake = GameObject.Find("Cake");
        //croissant = GameObject.Find("Croissant");
        donut = GameObject.Find("Donut");
        //chips = GameObject.Find("Chips_Bag");
        quadLeft = GameObject.Find("QuadLeft");
        quadRight = GameObject.Find("QuadRight");
        cerealBoxPlane = GameObject.Find("CerealBox1Plane");
        PTMedievalPeasant = GameObject.Find("PT_Medieval_Peasant_01_c");
        knight = GameObject.Find("knight");
        //Lumberjack3 = GameObject.Find("Lumberjack3");
        //Lumberpack = GameObject.Find("LumberPack");
        PTMedievalTree = GameObject.Find("PT_Medieval_Tree_1");
        cart = GameObject.Find("cart_4w");
        cartAd = GameObject.Find("cart_4w_ad");
        cartWheels = GameObject.Find("cart_wheels");
        PTMedievalRock = GameObject.Find("PT_Medieval_Rock_4");
        taco = GameObject.Find("Tacos");
        egg = GameObject.Find("Egg");
        drink= GameObject.Find("Drink_01");
        omelette = GameObject.Find("Omelette");

        knightMat = GameObject.Find("knightMat");
        //lumberjackMat3 = GameObject.Find("Lumberjack3Mat");
}
	
	// Update is called once per frame
	void Update () {

        pos1 = object1.GetComponent<PositionObject1>().posObject1;
        pos2 = object2.GetComponent<PositionObject2>().posObject2;
        distance = Vector3.Distance(pos1, pos2);
        detected = object2.GetComponent<PositionObject2>().detected;
        detected1 = object1.GetComponent<PositionObject1>().detected;
        if (distance >0 && distance <= 1 && detected && detected1)
        {
            //Debug.Log("Distance is:" + distance);
            inproxmity = true;
            //deactivateGameObjects();
            
        }
        else if (detected == false && detected1==true)
        {
            inproxmity = false;
        }
        else if (detected1 == false && detected == true)
        {
            inproxmity = false;
        }
        else if((distance > 1 || distance==0.0))
        {
            inproxmity = false;
            //activateGameObjects();
        }
        //Debug.Log("Distance is:" + distance);
    }

    private void OnGUI()
    {
        if(inproxmity)
        {
            if(!playSound)
            {
                enteredSoundSource.Play();
                playSound = true;
            }
            playCompletedSound = false;
            burger.SetActive(false);
            cake.SetActive(false);
            //croissant.SetActive(false);
            donut.SetActive(false);
            //chips.SetActive(false);
            quadLeft.SetActive(false);
            quadRight.SetActive(false);
            cerealBoxPlane.SetActive(false);
            PTMedievalPeasant.SetActive(false);
            PTMedievalRock.SetActive(false);
            knight.SetActive(false);
            //Lumberjack3.SetActive(false);
            //Lumberpack.SetActive(false);
            PTMedievalTree.SetActive(false);
            cart.SetActive(false);
            cartAd.SetActive(false);
            cartWheels.SetActive(false);
            cerealBox1CaloriesText.text = "300";
            cerealBox1CaloriesText.color = Color.green;
            //cerealBox1Button.GetComponent<Renderer>().material.color = Color.red;



            taco.SetActive(true);
            egg.SetActive(true);
            drink.SetActive(true);
            omelette.SetActive(true);
            knightMat.SetActive(true);
            //lumberjackMat3.SetActive(true);


        }
        else
        {
            if(playSound)
            {
                if(!playCompletedSound)
                {
                    completedSoundSource.Play();
                    playCompletedSound = true;
                }
            }
            playSound = false;
            burger.SetActive(true);
            cake.SetActive(true);
            //croissant.SetActive(true);
            donut.SetActive(true);
            //chips.SetActive(true);
            quadLeft.SetActive(true);
            quadRight.SetActive(true);
            cerealBoxPlane.SetActive(true);
            PTMedievalPeasant.SetActive(true);
            PTMedievalRock.SetActive(true);
            knight.SetActive(true);
            //Lumberjack3.SetActive(true);
            //Lumberpack.SetActive(true);
            PTMedievalTree.SetActive(true);
            cart.SetActive(true);
            cartAd.SetActive(true);
            cartWheels.SetActive(true);
            cerealBox1CaloriesText.text = "NA";
            cerealBox1CaloriesText.color = Color.black;
            //cerealBox1Button.GetComponent<Button>().colors = new Color(0.5f, 0.5f, 0.5f, 1.0f);
            //PTMedievalRock.SetActive(true);

            taco.SetActive(false);
            egg.SetActive(false);
            drink.SetActive(false);
            omelette.SetActive(false);
            knightMat.SetActive(false);
            //lumberjackMat3.SetActive(false);

        }

    }
    /*public void deactivateGameObjects()
    {
        burger.SetActive(false);
        cake.SetActive(false);
        croissant.SetActive(false);
        donut.SetActive(false);
        chips.SetActive(false);
        quadLeft.SetActive(false);
        quadRight.SetActive(false);
        cerealBoxPlane.SetActive(false);
        PTMedievalPeasant.SetActive(false);
        PTMedievalTree.SetActive(false);
        cart.SetActive(false);
        PTMedievalRock.SetActive(false);
    }
    public void activateGameObjects()
    {
        burger.SetActive(true);
        cake.SetActive(true);
        croissant.SetActive(true);
        donut.SetActive(true);
        chips.SetActive(true);
        quadLeft.SetActive(true);
        quadRight.SetActive(true);
        cerealBoxPlane.SetActive(true);
        PTMedievalPeasant.SetActive(true);
        PTMedievalTree.SetActive(true);
        cart.SetActive(false);
        PTMedievalRock.SetActive(true);
    }*/

}
