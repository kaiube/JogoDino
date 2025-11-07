using OpenTK.Mathematics;

namespace DinoGame
{
    public class Camera
    {
        private Vector3 position;
        private Vector3 target;

        public Camera(Vector3 position, Vector3 target)
        {
            this.position = position;
            this.target = target;
        }

        public Matrix4 GetViewMatrix()
        {
            return Matrix4.LookAt(position, target, Vector3.UnitY);
        }

        public Matrix4 GetProjectionMatrix(float aspectRatio)
        {
            return Matrix4.CreatePerspectiveFieldOfView(MathHelper.DegreesToRadians(45f), aspectRatio, 0.1f, 100f);
        }
    }
}