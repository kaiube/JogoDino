using OpenTK.Mathematics;

namespace DinoGame
{
    public class Ground
    {
        private Shader shader;
        private Vector3 color = new(0.4f, 0.25f, 0.1f);

        public Ground(Shader shader)
        {
            this.shader = shader;
        }

        public void Render(Matrix4 view, Matrix4 projection)
        {
            shader.Use();

            Matrix4 model = Matrix4.CreateScale(10f, 0.1f, 1f);
            shader.SetMatrix4("model", model);
            shader.SetMatrix4("view", view);
            shader.SetMatrix4("projection", projection);
            shader.SetVector3("color", color);

            Utils.DrawCube();
        }
    }
}