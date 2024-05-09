using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class test : MonoBehaviour
    {
        DialogSystem ds;
        TextArchitect architect;
        public int stringIndex;
        public float waitAmount;
        public GameObject Rawimage1;
        public GameObject Rawimage2;
        bool isWaiting;


        string[] lines = new string[]
        {
             "The sound of alarm going off." +
            "\nWhy now just a little bit more." +
            "\nSound continues." +
            "\nErh why now.",

            "What happened last night.",
              "Looking at his phone he sees that the clock is already past 9 and was supposed to get up from bed an hour ago!",
            "What." +
            "\nHow is it past 9 i was meant to get op at 8!",
            "He goes to turn of the alarm but is overwhelmed by a pukish sensation, and runs to the nearest sink" +
            "\nFuck, what happend last night",
            "\nDamit" +
            "\nHe gets dressed and rushes out of the door, " +
            "\nthe rain is pouring down and the trafic is a mess.",
             "\nHe puts up his hood and runs towards his workplace in a slow sluggish tempo do to his hangover from the drinking yesterday.",
           "\nWhy is this happening now of all days,",
           "\ni have to be on time or i'm done for." +
            "\n The weather is normally not this bad the rain is making my hair fall down into my eyes and is making it hard for me to see." +
            "\n The sounds of footsteps running in the water can be heard, but is suddenly replaced with a car using its horn and breaks",
           

        };
        public string[] getLines()
        {
        return lines;
        }
        // Start is called before the first frame update
        void Start()
        {
            ds = DialogSystem.instance;
            architect = new TextArchitect(ds.DialogContainer.TrueDialog);
            architect.buildMethod = TextArchitect.BuildMethod.typewriter;

        }

        // Update is called once per frame
        void Update()
        {
            if(Input.GetKeyUp(KeyCode.Space)&& !isWaiting) 
            {
                stringIndex++;
                if(stringIndex == 5)
                {

                    StartCoroutine(WaitForImage1());

                }
                else if(stringIndex==9)
                {
                    StartCoroutine(WaitForImage2());

                }
                else
                {
                    architect.Build(lines[stringIndex]);

                }
            }
           
        }

        IEnumerator WaitForImage1()
        {
            isWaiting = true;
            Rawimage1.SetActive(true);
            yield return new WaitForSeconds(waitAmount);
            Rawimage1.SetActive(false);
            isWaiting = false;
            architect.Build(lines[stringIndex]);

        }


        IEnumerator WaitForImage2()
        {
            isWaiting = true;
            Rawimage2.SetActive(true);
            yield return new WaitForSeconds(waitAmount); 
            Rawimage2.SetActive(false);
            isWaiting = false;
            //architect.Build(lines[stringIndex]);

        }
    }






