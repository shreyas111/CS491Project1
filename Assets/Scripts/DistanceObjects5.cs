using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class DistanceObjects5 : MonoBehaviour
{

    public GameObject object1;
    public GameObject object5;
    public Vector3 pos1;
    public Vector3 pos5;
    float distance;
    bool detected;
    bool detected1;

    private GameObject wallBack5;
    private GameObject floor5;

    private bool inproxmity;
    public AudioSource enteredSoundSource;
    public AudioSource completedSoundSource;
    public bool playSound = false;
    public bool playCompletedSound = false;
    private GameObject lumberjackMat1;
    private GameObject lumberjackMat3;


    public Text box5CaloriesText;

    // Use this for initialization
    void Start()
    {

        wallBack5 = GameObject.Find("CerealBox5WallBackQuad");
        floor5 = GameObject.Find("CerealBox5Plane");
        lumberjackMat1 = GameObject.Find("Lumberjack1Mat");
        lumberjackMat3 = GameObject.Find("Lumberjack3Mat");


    }

    // Update is called once per frame
    void Update()
    {

        pos1 = object1.GetComponent<PositionObject1>().posObject1;
        pos5 = object5.GetComponent<PositionObject5>().posObject5;
        detected = object5.GetComponent<PositionObject5>().detected;
        detected1 = object1.GetComponent<PositionObject1>().detected;
        distance = Vector3.Distance(pos1, pos5);
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


            wallBack5.SetActive(false);
            floor5.SetActive(false);
            
            box5CaloriesText.text = "630";
            box5CaloriesText.color = new Color(99,0,0,1);

            lumberjackMat3.SetActive(true);
            lumberjackMat1.SetActive(true);


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

            wallBack5.SetActive(true);
            floor5.SetActive(true);
            
            box5CaloriesText.text = "NA";
            box5CaloriesText.color = Color.black;

            lumberjackMat3.SetActive(false);
            lumberjackMat1.SetActive(false);
        }

    }

}
