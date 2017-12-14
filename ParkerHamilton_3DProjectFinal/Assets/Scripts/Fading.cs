using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fading : MonoBehaviour {
    public Texture2D fadeOutTexture;
    public float fadeSpeed = 0.4f;

    private int drawDepth = -1000;
    private float alpha = 1.0f;
    private int fadeDir = -1;

    private void OnGUI()
    {
        //fade out/in he alpha value using a direction, a speed and a Time.DeltaTime to convert the operation to seconds
        alpha += fadeDir * fadeSpeed * Time.deltaTime;

        //force (clasp) the number between 0  and 1 because GUI.color uses alpha values between 0 and 1
        alpha = Mathf.Clamp01(alpha);

        //set color of our GUI (in this case our texture). All color values remain the same & ALpha is set to alpha varibale
        GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, alpha); //set alpha value
        GUI.depth = drawDepth; //make the black texture render on op (drawn last)
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), fadeOutTexture); //draw the texture to fit the entire screen area
    }

    //sets fadeDir to the direction parameter making the scene fade in if -1 and ou if 1
    public float BeginFade( int direction )
    {
        fadeDir = direction;
        return (fadeSpeed); //return the fadeSpeed variable so it's easy to time the Applicaton.LoadLevel();
        
    }
    //OnLevelWasLoaded is called whe na level is loaded. It takes loaded level index (int) as a paratmer so you can limit the fade in to certain scenes
    void OnLevelWasLoaded()
    {
        //alpha = 1; //use his if he alpha is not se to 1 by default
        BeginFade(-1);  //call the fade in function
    }
}
