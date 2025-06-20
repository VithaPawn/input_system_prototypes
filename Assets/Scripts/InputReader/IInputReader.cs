namespace InputReader
{
    using System;
    using UnityEngine;

    public interface IInputReader
    {
        public Vector2 Move     { get; }
        public bool    Jump     { get; }
        public bool    Crouch   { get; }
        public bool    Sprint   { get; }
        public bool    Interact { get; }

        public event Action OnJumpPressed;
        public event Action OnInteractPressed;
    }
}