using UnityEngine;

/* ScriptName:      UnitGravity.cs
 * Author(s):       Matthew Perry
 * Last Updated:    5-21-2026
 * Description:     This is a script that adds Gravity to a Unit.
 */

namespace OneThread.Core.Units
{
    public class UnitGravity : MonoBehaviour
    {/*

        #region Variables:

        [Header("GRAVITY")] 
        
        [SerializeField] private float _currentVerticalSpeed;
        [SerializeField] private float _fallClamp = -40f;
        [SerializeField] private float _minFallSpeed = 80f;
        [SerializeField] private float _maxFallSpeed = 120f;
        private float _fallSpeed;

        

        #endregion

        #region Private Functions:
        private void CalculateGravity()
        {
            if (_colDown)
            {
                // Move out of the ground
                if (_currentVerticalSpeed < 0)
                {
                    _currentVerticalSpeed = 0;
                } 
            }
            else
            {
                // Add downward force while ascending if we ended the jump early
                //var fallSpeed = _endedJumpEarly && _currentVerticalSpeed > 0 ? _fallSpeed * _jumpEndEarlyGravityModifier : _fallSpeed;
                // Fall
                _currentVerticalSpeed -= fallSpeed * Time.deltaTime;
                // Clamp
                if (_currentVerticalSpeed < _fallClamp) _currentVerticalSpeed = _fallClamp;
            }
        }
        #endregion
    */}
}
