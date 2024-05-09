using Godot;
using ProjectBoostMono.Scripts.Helper;
using System;

namespace ProjectBoostMono.Scripts.Characters;
public partial class Player : RigidBody3D
{
    [ExportGroup("Child Nodes")]
    [Export]
    public AudioStreamPlayer CrashSFXPlayer { get; private set;}

    [Export]
    public AudioStreamPlayer WinSFXPlayer { get; private set;}

    [Export]
    public AudioStreamPlayer3D RocketSFXPlayer { get; private set; }

    [ExportGroup("")]
    /// <summary>
    /// How fast the rocket launch
    /// </summary>
    // How fast the rocket launch
    [Export(PropertyHint.Range, "750,3000")]
    // How fast the rocket launch
    private float _velocity = 1000.0f;

    [Export]
    private float _rotationSpeed = 100.0f;
    private Vector3 _movementVector;

    
    // Set to true when transitioning scene to prevent multible calls on collision
    private bool _isSceneTransitioning = false;



    // Game Loop Methods---------------------------------------------------------------------------

    public override void _Ready()
    {
        BodyEntered += OnBodyEntered;
    }

    public override void _Process(double delta)
    {
        // _movementVector = Vector3.Zero;

        if (Input.IsActionPressed(InputActionNames.User.BOOST))
        {
            ApplyCentralForce(Basis.Y * _velocity * (float)delta);

            if (!RocketSFXPlayer.Playing)
            {
                RocketSFXPlayer.Play();
            }
        }
        else
        {
            RocketSFXPlayer.Stop();
        }

        if (Input.IsActionPressed(InputActionNames.User.ROTATE_LEFT))
        {
            ApplyTorque(new Vector3(0.0f, 0.0f, _rotationSpeed * (float)delta));
        }

        if (Input.IsActionPressed(InputActionNames.User.ROTATE_RIGHT))
        {
            ApplyTorque(new Vector3(0.0f, 0.0f, -1 * _rotationSpeed * (float)delta));
        }
    }

    // Member Methods------------------------------------------------------------------------------

    /// <summary>
    /// Initiate playing crashing event and gem behaviour
    /// </summary>
    private void StartCrashSequence()
    {
        GD.Print("KABOOM!!!!!!!");
        CrashSFXPlayer.Play();
        Tween tween = CreateTween();
        // tween.TweenInterval(1.0f);
        tween.TweenInterval(CrashSFXPlayer.Stream.GetLength() + 0.5f);
        tween.TweenCallback(Callable.From(() => GetTree().ReloadCurrentScene()));
    }

    /// <summary>
    /// Initiate playing winning event and gem behaviour
    /// </summary>
    private void CompletLevel(string nextLevelPath)
    {
        GD.Print("Congrats ;)");
        WinSFXPlayer.Play();
        
        Tween tween = CreateTween();
        // tween.TweenInterval(1.0f);

        tween.TweenInterval(WinSFXPlayer.Stream.GetLength() + 0.5f);
        tween.TweenCallback(Callable.From(() => GetTree().ChangeSceneToFile(nextLevelPath)));
    }

    // Signal Methods------------------------------------------------------------------------------

    private void OnBodyEntered(Node body)
    {
        if (_isSceneTransitioning)
        {
            return;
        }

        if (body.GetGroups().Contains(GroupName.DANGER))
        {
            _isSceneTransitioning = true;
            SetProcess(false);

            StartCrashSequence();
        }
        else if (body.GetGroups().Contains(GroupName.GOAL))
        {
            _isSceneTransitioning = true;
            SetProcess(false);

            _isSceneTransitioning = true;
            LandingPad pad = body as LandingPad;
            CallDeferred(MethodName.CompletLevel, pad.NextLevelFilePath);
            // CompletLevel(pad.NextLevelFilePath);
        }

    }
}
