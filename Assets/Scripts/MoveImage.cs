using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveImage : MonoBehaviour
{
    [SerializeField] private Texture2D Image;
    private Vector2 ImagePosition = new Vector2(385, 100);
    private Vector2 ImageSize = new Vector2(500, 500);

    private void ButtonTemplate(ref Vector2 ButtonBoxPosition, ref Vector2 ButtonPosition, ref Vector2 ButtonBoxSize, ref Vector2 ButtonSize, string Direction)
    {
        GUI.Box(new Rect(ButtonBoxPosition, ButtonBoxSize), "Move");

        if (GUI.Button(new Rect(ButtonPosition, ButtonSize), Direction))
        {
            if (Direction == "Up")
            {
                ImagePosition.y -= 1;
            }
            if (Direction == "Down")
            {
                ImagePosition.y += 1;
            }
            if (Direction == "Left")
            {
                ImagePosition.x -= 1;
            }
            if (Direction == "Right")
            {
                ImagePosition.x += 1;
            }

        }
    }

    private void OnGUI()
    {
        GUI.Box(new Rect(ImagePosition, ImageSize), Image);

        Vector2 BoxSize = new Vector2(100, 50);
        Vector2 ButtonSize = new Vector2(80, 20);


        Vector2 UpBoxPosition = new Vector2(10, 10);
        Vector2 UpButtonPosition = new Vector2(20, 35);

        Vector2 DownBoxPosition = new Vector2(1180, 10);
        Vector2 DownButtonPosition = new Vector2(1190, 35);

        Vector2 RightBoxPosition = new Vector2(1180, 670);
        Vector2 RightButtonPosition = new Vector2(1190, 695);

        Vector2 LeftBoxPosition = new Vector2(10, 670);
        Vector2 LeftButtonPosition = new Vector2(20, 695);

        ButtonTemplate(ref UpBoxPosition, ref UpButtonPosition, ref BoxSize, ref ButtonSize, "Up");
        ButtonTemplate(ref DownBoxPosition, ref DownButtonPosition, ref BoxSize, ref ButtonSize, "Down");
        ButtonTemplate(ref RightBoxPosition, ref RightButtonPosition, ref BoxSize, ref ButtonSize, "Right");
        ButtonTemplate(ref LeftBoxPosition, ref LeftButtonPosition, ref BoxSize, ref ButtonSize, "Left");
    }
}
