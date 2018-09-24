using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class DistanceObjects6 : MonoBehaviour
{

    public GameObject object3;
    public GameObject object5;
    public Vector3 pos3;
    public Vector3 pos5;
    float distance;
    bool detected3;
    bool detected5;

    private bool inproxmity;
    public AudioSource enteredSoundSource;
    public AudioSource completedSoundSource;
    public bool playSound = false;
    public bool playCompletedSound = false;

    /*private GameObject wallBack;
    private GameObject wallLeft;
    private GameObject wallRight;
    private GameObject floor;
    private GameObject spaceManModel1;
    private GameObject spaceManModel2;

    private GameObject wallBack5;
    private GameObject floor5;*/
    private GameObject spacemanjack;



    // Use this for initialization
    void Start()
    {
        spacemanjack= GameObject.Find("spacemanjack");
        /*wallBack = GameObject.Find("WallBack");
        wallLeft = GameObject.Find("WallLeft");
        wallRight = GameObject.Find("WallRight");
        floor = GameObject.Find("floor_5");
        spaceManModel1 = GameObject.Find("space_man_model");
        spaceManModel2 = GameObject.Find("space_man_model2");

        wallBack5 = GameObject.Find("CerealBox5WallBackQuad");
        floor5 = GameObject.Find("CerealBox5Plane");*/
    }

    // Update is called once per frame
    void Update()
    {

        pos3 = object3.GetComponent<PositionObject3>().posObject3;
        pos5 = object5.GetComponent<PositionObject5>().posObject5;
        //detected3 = object3.GetComponent<PositionObject3>().detected3;
        //detected5 = object5.GetComponent<PositionObject5>().detected5;
        distance = Vector3.Distance(pos3, pos5);


        /*if (distance > 0 && distance <= 1 && detected3 && detected5)
        {

            inproxmity = true;
            //deactivateGameObjects();

        }
        else if (detected3 == false && detected5 == true)
        {
            inproxmity = false;
        }
        else if (detected5 == false && detected3 == true)
        {
            inproxmity = false;
        }
        else if ((distance > 1 || distance == 0.0) && (detected3 && detected5))
        {
            inproxmity = false;
            //activateGameObjects();
        }*/
        if (distance > 0 && distance <= 1)
        {

            inproxmity = true;
            //deactivateGameObjects();

        }
        else if (distance > 1 || distance == 0.0)
        {
            inproxmity = false;
            //activateGameObjects();
        }
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

            spacemanjack.SetActive(false);

            /*wallBack.SetActive(false);
            wallLeft.SetActive(false);
            wallRight.SetActive(false);
            floor.SetActive(false);
            spaceManModel1.SetActive(false);
            spaceManModel2.SetActive(false);

            wallBack5.SetActive(false);
            floor5.SetActive(false);*/


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

            /* wallBack.SetActive(true);
             wallLeft.SetActive(true);
             wallRight.SetActive(true);
             floor.SetActive(true);
             spaceManModel1.SetActive(true);
             spaceManModel2.SetActive(true);

             wallBack5.SetActive(true);
             floor5.SetActive(true);*/
            spacemanjack.SetActive(true);


        }
    }
}
