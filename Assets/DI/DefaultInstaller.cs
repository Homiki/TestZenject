using UnityEngine;
using Zenject;

namespace DI
{
    public class DefaultInstaller : MonoInstaller<DefaultInstaller>
    {
        [SerializeField] private FizzBuzzView _fizzBuzzView;
        public override void InstallBindings()
        {
            Container.Bind<IRandomNumber>().To<RandomNumberService>().AsSingle();
            Container.BindInstance(_fizzBuzzView).AsSingle();
            Container.Bind<FizzBuzzService>().AsSingle();
        }
    }
}