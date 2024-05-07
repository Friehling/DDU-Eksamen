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
             "lyden af et vækkeur." +
            "\nwhy now just a little bit more." +
            "                                                                              sound continues." +
            "                                                                                               erh why now.",

            "what happened last night.",
              "looking at his phone he sees that the clock is past 9 and gets up from bed!",
            "what." +
            "                                                                                                            how is it past 9 i was meant to get op at 8!",
            "he goes to turn of the alarm but is overvalued by a pukish sensation, and get over to a sink" +
            "                                                                                                           fuck, what happend last night",
            "damit" +
            "                                                                               he gets dressed and rushes out the door, " +
            "                                                                                           The rain is pouring down and the trafik is stuck.",
             "he puts up his hood and runs the distance sluggish doe to his hangover",
           "why is this happening now of all days",
           "i have to be on time or i'm done for" +
            "\n the weather is normally not this bad the rain i making my hair fall down into my eyes and making it hard to see," +
            "\n sounds of footsteps running in the water can be heard, but is suddenly replaced with a car using its horn and breaks  ",

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
            architect.Build(lines[stringIndex]);

        }
    }






