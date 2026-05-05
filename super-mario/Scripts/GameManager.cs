using Godot;
using System;

public partial class GameManager : Node
{
    public int m_lives, m_coins;
   [Export] public float _gravity;
    public static GameManager Instance;

    public override void _Ready()
    {
        Instance = this;
    }

}
