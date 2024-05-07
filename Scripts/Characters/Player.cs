using Godot;
using ProjectBoostMono.Scripts.Helper;
using System;

namespace ProjectBoostMono.Scripts.Characters;
public partial class Player : Node3D
{
    private Vector3 _movementVector;



    // Game Loop Methods---------------------------------------------------------------------------
    public override void _Process(double delta)
    {
        // _movementVector = Vector3.Zero;

        if (Input.IsActionPressed(InputActionNames.BuiltIn.UI_ACCEPT))
        {
            Position = new Vector3(Position.X, Position.Y + (float)delta, Position.Z);
        }

        if (Input.IsActionPressed(InputActionNames.BuiltIn.UI_LEFT))
        {
            RotateZ(-(float)delta);
        }

        if (Input.IsActionPressed(InputActionNames.BuiltIn.UI_RIGHT))
        {
            RotateZ((float)delta );
        }
    }
}
