using UnityEngine;

/* ScriptName:      UnitMovement.cs
 * Author(s):       Matthew Perry
 * Last Updated:    5-21-2026
 * Description:     This is a script that manages a Units movement.
 */

namespace OneThread.Core.Units
{
    public class UnitMovement : MonoBehaviour
    { /*

        #region Public Variables:

        public Vector3 RawMovement { get; private set; }

        #endregion Public Variables


        #region Private Variables:

        [Header("MOVE")]

        [SerializeField, Tooltip("Raising this value increases collision accuracy at the cost of performance.")]

        private int _freeColliderIterations = 10;

        #endregion Private Variables

        #region Private Behaviors:

        // We cast our bounds before moving to avoid future collisions
        private void MoveCharacter() 
        {
            var pos = transform.position + _characterBounds.center;
            RawMovement = new Vector3(_currentHorizontalSpeed, _currentVerticalSpeed); // Used externally
            var move = RawMovement * Time.deltaTime;
            var furthestPoint = pos + move;

            // check furthest movement. If nothing hit, move and don't do extra checks
            var hit = Physics2D.OverlapBox(furthestPoint, _characterBounds.size, 0, _groundLayer);

            if (!hit) 
            {
                transform.position += move;
                return;
            }
            
            // otherwise increment away from current pos; see what closest position we can move to

            var positionToMoveTo = transform.position;

            for (int i = 1; i < _freeColliderIterations; i++) 
            {
                // increment to check all but furthestPoint - we did that already
                var t = (float)i / _freeColliderIterations;
                var posToTry = Vector2.Lerp(pos, furthestPoint, t);
                if (Physics2D.OverlapBox(posToTry, _characterBounds.size, 0, _groundLayer)) 
                {
                    transform.position = positionToMoveTo;

                    // We've landed on a corner or hit our head on a ledge. Nudge the player gently
                    if (i == 1) 
                    {
                        if (_currentVerticalSpeed < 0) _currentVerticalSpeed = 0;
                        var dir = transform.position - hit.transform.position;
                        transform.position += dir.normalized * move.magnitude;
                    }
                    return;
                }
                positionToMoveTo = posToTry;
            }
        }

        #endregion
    */}
}