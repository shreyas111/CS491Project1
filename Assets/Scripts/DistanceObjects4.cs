using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class DistanceObjects4 : MonoBehaviour
{

    public GameObject object1;
    public GameObject object4;
    public Vector3 pos1;
    public Vector3 pos4;
    float distance;
    bool detected;
    bool detected1;

    private GameObject wallBack2;
    private GameObject floor1;
    private GameObject mascot;
    private GameObject mascotMat;

    private bool inproxmity;
    public AudioSource enteredSoundSource;
    public AudioSource completedSoundSource;
    public bool playSound = false;
    public bool playCompletedSound = false;

    public Text box4CaloriesText;

    // Use this for initialization
    void Start()
    {

        wallBack2 = GameObject.Find("WallBack2");
        floor1 = GameObject.Find("Floor1");
        mascot = GameObject.Find("WK_heavy_infantry_08_attack_B");
        mascotMat= GameObject.Find("WK_heavy_infantry_08_attack_B1");

    }

    // Update is called once per frame
    void Update()
    {

        pos1 = object1.GetComponent<PositionObject1>().posObject1;
        pos4 = object4.GetComponent<PositionObject4>().posObject4;
        detected = object4.GetComponent<PositionObject4>().detected;
        detected1 = object1.GetComponent<PositionObject1>().detected;
        distance = Vector3.Distance(pos1, pos4);
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


            wallBack2.SetActive(false);
            floor1.SetActive(false);
            mascot.SetActive(false);
            box4CaloriesText.text = "130";
            box4CaloriesText.color = Color.green;

            mascotMat.SetActive(true);


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

            wallBack2.SetActive(true);
            floor1.SetActive(true);
            mascot.SetActive(true);
            box4CaloriesText.text = "NA";
            box4CaloriesText.color = Color.black;

            mascotMat.SetActive(false);
        }

    }

}
