using Godot;
using System;

public partial class MovingHazard : AnimatableBody3D
{
    [ExportCategory("Direction and Duration")]
    [Export]
    private Vector3 _direction;

    [Export]
    private float _duration;



    // Game Loop Methods---------------------------------------------------------------------------
    public override void _Ready()
    {
        Tween tween = CreateTween();

        tween.SetLoops();
        tween.SetTrans(Tween.TransitionType.Sine);

        tween.TweenProperty(this, 
            "global_position", 
            GlobalPosition + _direction,
            _duration
        );

        tween.TweenProperty(this, 
            "global_position", 
            GlobalPosition,
            _duration
        );
    }
}