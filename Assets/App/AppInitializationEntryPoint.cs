using Shafir.Arkanoid.SceneManagement;
using VContainer.Unity;

namespace Shafir.Arkanoid.App
{
    public class AppInitializationEntryPoint : IStartable
    {
        private SceneLoader _sceneLoader;

        public void Start()
        {
            _sceneLoader.LoadScene(Scenes.LoadContent);
        }

        public AppInitializationEntryPoint(SceneLoader sceneLoader) =>
            _sceneLoader = sceneLoader;
    }
}