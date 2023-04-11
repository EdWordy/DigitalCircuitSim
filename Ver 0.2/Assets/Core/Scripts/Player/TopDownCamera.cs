using DigitalCircuits.Core.CodeTRON;
using UnityEngine;

namespace DigitalCircuits.Core
{
    public class TopDownCamera : MonoBehaviour
    {
        public int SpeedModifier = 5;
        public int Speed = 1;

        // Start is called before the first frame update
        void Start()
        {
            Camera.main.orthographicSize = 4.5f;
        }

        // Update is called once per frame
        void Update()
        {
            // set local variables
            float xAxisValue = Input.GetAxis("Horizontal") / SpeedModifier;
            float yAxisValue = Input.GetAxis("Vertical") / SpeedModifier;

            // if the current camera isn't null do a transform or two
            if (Camera.main != null)
            {
                // WASD control
                Camera.main.transform.Translate(new Vector3(xAxisValue, yAxisValue, 0.0f));

                // zoom control
                // MAX
                if (Input.mouseScrollDelta.y > 0 && Camera.main.orthographicSize < 6.5f)
                {
                    Camera.main.orthographicSize += Speed;
                }
                // MIN
                if (Input.mouseScrollDelta.y < 0 && Camera.main.orthographicSize > 2.5f)
                {
                    Camera.main.orthographicSize -= Speed;
                }

                // edge boxing
                // X axis
                if (Camera.main.transform.position.x > 7.5f)
                {
                    Camera.main.transform.Translate(-xAxisValue, 0.0f, 0.0f);
                }
                else if (Camera.main.transform.position.x < -7.5f)
                {
                    Camera.main.transform.Translate(-xAxisValue, 0.0f, 0.0f);
                }
                // Y axis
                if (Camera.main.transform.position.y > 7.5f)
                {
                    Camera.main.transform.Translate(0.0f, -yAxisValue, 0.0f);
                }
                else if (Camera.main.transform.position.y < -7.5f)
                {
                    Camera.main.transform.Translate(0.0f, -yAxisValue, 0.0f);
                }
            }
        }
    }
}
