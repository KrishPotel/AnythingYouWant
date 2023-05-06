using Godot;
using System;

public class Player : KinematicBody2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";
    // Called when the node enters the scene tree for the first time.

    private Vector2 direction;
    [Export]
    private int speed;

    public override void _Ready()
    {
        
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {
        if(Input.IsActionPressed("ui_right")){
            direction.x=1 * speed;
        }

        MoveAndSlide(direction, Vector2.Up);
    }
}
