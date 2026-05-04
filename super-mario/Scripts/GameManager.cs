using Godot;
using System;

public partial class GameManager : Node
{
    public int lives, coins;
   [Export] public float gravity;
    public static GameManager Instance;

    public override void _Ready()
    {
        Instance = this;
    }

}
