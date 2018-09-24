using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class DistanceObjects1 : MonoBehaviour
{

    public GameObject object1;
    public GameObject object3;
    public Vector3 pos1;
    public Vector3 pos3;
    float distance;
    bool detected;
    bool detected1;
    /*private GameObject burger;
    private GameObject cake;
    private GameObject croissant;
    private GameObject donut;
    private GameObject chips;*/

    private GameObject wallBack;
    private GameObject wallLeft;
    private GameObject wallRight;
    private GameObject floor;
    //private GameObject chair;
    private GameObject bunkBed;
    private GameObject desk;
    private GameObject battery;
    private GameObject spaceManModel1;
    private GameObject spaceManModel2;

    private GameObject SpaceManModelMat1;
    private GameObject SpaceManModelMat2;

    private bool inproxmity;
    public AudioSource enteredSoundSource;
    public AudioSource completedSoundSource;
    public bool playSound = false;
    public bool playCompletedSound = false;

    public Text can1CaloriesText;

    // Use this for initialization
    void Start()
    {
        /*burger = GameObject.Find("Burger");
        cake = GameObject.Find("Cake");
        croissant = GameObject.Find("Croissant");
        donut = GameObject.Find("Donut");
        chips = GameObject.Find("Chips_Bag");*/
 

        wallBack = GameObject.Find("WallBack");
        wallLeft = GameObject.Find("WallLeft");
        wallRight = GameObject.Find("WallRight");
        floor = GameObject.Find("floor_5");
        //chair = GameObject.Find("decorative_chair");
        bunkBed = GameObject.Find("bunk_bed");
        desk = GameObject.Find("desk");
        battery = GameObject.Find("Battery_medium");
        spaceManModel1 = GameObject.Find("space_man_model");
        spaceManModel2 = GameObject.Find("space_man_model2");

        SpaceManModelMat1 = GameObject.Find("space_man_modelMat1");
        SpaceManModelMat2 = GameObject.Find("space_man_modelMat2");

    }

    // Update is called once per frame
    void Update()
    {

        pos1 = object1.GetComponent<PositionObject1>().posObject1;
        pos3 = object3.GetComponent<PositionObject3>().posObject3;
        detected= object3.GetComponent<PositionObject3>().detected;
        detected1 = object1.GetComponent<PositionObject1>().detected;
        distance = Vector3.Distance(pos1, pos3);
        //Debug.Log(detected);

        if (distance > 0 && distance <= 1 && detected && detected1)
        {

            inproxmity = true;
            //deactivateGameObjects();

        }
        else if (detected == false && detected1 == true)
        {
            inproxmity = false;
        }
        else if (detected1 == false && detected == true)
        {
            inproxmity = false;
        }
        else if ((distance > 1 || distance == 0.0))
        {
            inproxmity = false;
            //activateGameObjects();
        }
        //Debug.Log("Distance is:" + distance);
    }

    private void OnGUI()
    {
        if (inproxmity)
        {
            if (!playSound)
            {
                enteredSoundSource.Play();
                playSound = true;
            }
            playCompletedSound = false;
            /*burger.SetActive(false);
            cake.SetActive(false);
            croissant.SetActive(false);
            donut.SetActive(false);
            chips.SetActive(false);*/

            wallBack.SetActive(false);
            wallLeft.SetActive(false);
            wallRight.SetActive(false);
            floor.SetActive(false);
            //chair.SetActive(false);
            bunkBed.SetActive(false);
            desk.SetActive(false);
            battery.SetActive(false);
            spaceManModel1.SetActive(false);
            spaceManModel2.SetActive(false);
            can1CaloriesText.text = "900";
            can1CaloriesText.color = Color.red;

            SpaceManModelMat1.SetActive(true);
            SpaceManModelMat2.SetActive(true);


        }
        else
        {
            if (playSound)
            {
                if (!playCompletedSound)
                {
                    completedSoundSource.Play();
                    playCompletedSound = true;
                }
            }
            playSound = false;
            /*burger.SetActive(true);
            cake.SetActive(true);
            croissant.SetActive(true);
            donut.SetActive(true);
            chips.SetActive(true);*/

            wallBack.SetActive(true);
            wallLeft.SetActive(true);
            wallRight.SetActive(true);
            floor.SetActive(true);
            //chair.SetActive(true);
            bunkBed.SetActive(true);
            desk.SetActive(true);
            battery.SetActive(true);
            spaceManModel1.SetActive(true);
            spaceManModel2.SetActive(true);
            can1CaloriesText.text = "NA";
            can1CaloriesText.color = Color.black;

            SpaceManModelMat1.SetActive(false);
            SpaceManModelMat2.SetActive(false);


        }

    }

}
