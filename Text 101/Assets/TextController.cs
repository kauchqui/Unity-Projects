using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {
    public int blanketCounter = 0;
    public Text text;
    private enum States { cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, freedom};
    private States state;
    private States myState;
	// Use this for initialization
	void Start () {
        text.text = "hello world";
        myState = States.cell;
    }
	
	// Update is called once per frame
	void Update () {
        if(myState == States.cell)
        {
            state_cell();
        }
        else if (myState == States.sheets_0)
        {
            state_sheets_0();
        }
        else if (myState == States.sheets_1)
        {
            state_sheets_1();
        }
        else if (myState == States.lock_0)
        {
            state_lock_0();
        }
        else if (myState == States.lock_1)
        {
            state_lock_1();
        }
        else if (myState == States.mirror)
        {
            state_mirror();
        }
        else if (myState == States.cell_mirror)
        {
            state_cell_mirror();
        }
        else if (myState == States.freedom)
        {
            state_freedom();
        }

    }
    void state_cell()
    {
        text.text = "You are trapped in a prison cell. There seems to be no way out... " +
                        "You look into the mirror and let out a heavy sigh, and wrap yourself up in the nearest blanket. " +
                        "You'd try the door again but it's obviously locked from the outside.\n\n" +
                        "Press S to wrap yourself tighter in the blanket.\n" +
                        "Press M to look into the mirror\n" +
                        "Press L to inspect the lock.";
        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.sheets_0;
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.lock_0;
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            myState = States.mirror;
        }

    }
    void state_sheets_0()
    {

            text.text = "You grab the edges of the blanket and pull them closer to your body.\n\n"+
                         "Press R to roam around the cell";
        
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }
    void state_sheets_1()
    {

        text.text = "You stab the metal pin through the fabric. That wasn't satisfying or productive.\n\n" +
                     "Press Y to go to the cell door.";

        if (Input.GetKeyDown(KeyCode.Y))
        {
            myState = States.lock_1;
        }
    }
    void state_lock_0()
    {
        text.text = "Yup that's a lock alright, and it's been pretty fucking locked for five years now.\n\n" +
                     "Press R to roam around the cell";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }
    void state_lock_1()
    {
        text.text = "You spend thirty minutes jamming the metal pins into the lock and eventually hear a click. " +
                    "You let out an excited yell and push on the door as hard as you can while twisting the handle. "+
                    "The door doesn't budge an inch. Your heart sinks and you walk back into the cell, but while doing so you hear the door swing open."+
                    "You forgot to pull not push. Thank god nobody was watching you.\n\n"+
                     "Press F to leave the cell";
        if (Input.GetKeyDown(KeyCode.F))
        {
            myState = States.freedom;
        }
    }
    void state_mirror()
    {

        text.text = "You look into the mirror and feel your face heat up in anger. You clench your fist...\n\n " +
                     "Press T to smash the mirror or R to return to the middle of the cell";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            myState = States.cell_mirror;
        }
    }
    void state_cell_mirror()
    {

        text.text = "You punch the mirror as hard as you can. The metal pins that were holding up the mirror fall to the floor.\n\n" +
                     "Press X to use the pins on the blanket or Y to use the pins with the lock";

        if (Input.GetKeyDown(KeyCode.X))
        {
            myState = States.sheets_1;
        }
        else if (Input.GetKeyDown(KeyCode.Y))
        {
            myState = States.lock_1;
        }
    }
    void state_freedom()
    {

        text.text = "You're finally free and you're surprised it was that easy. Maybe you are as dumb as you look.\n\n" +
                     "Press R to play again.";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }
}

